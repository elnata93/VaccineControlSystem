using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Historial : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();
        public int HistorialVacunaId { get; set; }
        public string  CentroSalud { get; set; }
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        public int PacienteId { get; set; }
        public int PacienteVacunaId { get; set; }
        public string PrimeraDosis { get; set; }
        public string SegundaDosis { get; set; }
        public string TerceraDosis { get; set; }
        public string PrimerRefuerzo { get; set; }
        public string SegundoRefuerzo { get; set; }

        public Historial()
        {
            this.HistorialVacunaId = 0;
            this.CentroSalud = "";
            this.Provincia = "";
            this.Municipio = "";
            this.PacienteId = 0;
            this.PacienteVacunaId = 0;
            this.PrimeraDosis = "";
            this.SegundaDosis = "";
            this.TerceraDosis = "";
            this.PrimerRefuerzo = "";
            this.SegundoRefuerzo = "";
        }

        public Historial(int historialVacunaId, string centroSalud, string provincia, string municipio,int pacienteId, string primeraDosis,string segundaDosis,string terceraDosis,string primerRefuerzo,string segundoRefuerzo)
        {
            this.HistorialVacunaId = historialVacunaId;
            this.CentroSalud = CentroSalud;
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.PacienteId = PacienteId;
            this.PrimeraDosis = PrimeraDosis;
            this.SegundaDosis = SegundaDosis;
            this.TerceraDosis = TerceraDosis;
            this.PrimerRefuerzo = PrimerRefuerzo;
            this.SegundoRefuerzo = SegundoRefuerzo;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into HistorialVacuna(CentroSalud, Provincia, Municipio,PacienteId, PrimeraDosis,SegundaDosis,TerceraDosis,PrimerRefuerzo,SegundoRefuerzo) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}','{8}')",
                    this.CentroSalud,this.Provincia,this.Municipio,this.PacienteId,this.PrimeraDosis,this.SegundaDosis,this.TerceraDosis,this.PrimerRefuerzo,this.SegundoRefuerzo));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("update HistorialVacuna set CentroSalud='{0}', Provincia='{1}', Municipio='{2}',PacienteId={3}, PrimeraDosis='{4}',SegundaDosis='{6}',TerceraDosis'{7}',PrimerRefuerzo='{8}',SegundoRefuerzo='{9}' where HistorialVacunaId={10}) values(,,,,,,,,)",
                    this.CentroSalud, this.Provincia, this.Municipio, this.PacienteId, this.PrimeraDosis, this.SegundaDosis, this.TerceraDosis, this.PrimerRefuerzo, this.SegundoRefuerzo,this.HistorialVacunaId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("delete from HistorialVacunas where HistorialVacunaId={0}", this.HistorialVacunaId));

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable data = new DataTable();
            DataTable dt = new DataTable();
            data = conexion.ObtenerDatos(String.Format("select * from HistorialVacunas where HistorialVacunaId= " + IdBuscado));

            if (data.Rows.Count > 0)
            {
                this.HistorialVacunaId = (int)data.Rows[0]["HistorialVacunaId"];
                this.CentroSalud = data.Rows[0]["CentroSalud"].ToString();
                this.Provincia = data.Rows[0]["Provincia"].ToString();
                this.Municipio = data.Rows[0]["Municipio"].ToString();
                this.PacienteId = (int)data.Rows[0]["PacienteId"];
                this.PrimeraDosis = data.Rows[0]["PrimeraDosis"].ToString();
                this.SegundaDosis = data.Rows[0]["SegundaDosis"].ToString();
                this.TerceraDosis = data.Rows[0]["TerceraDosis"].ToString();
                this.PrimerRefuerzo = data.Rows[0]["PrimerRefuerzo"].ToString();
                this.SegundoRefuerzo = data.Rows[0]["SegundoRefuerzo"].ToString();
                
            }

            return data.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!ordenFinal.Equals(""))
                ordenFinal = " Order by " + Orden;
            return conexion.ObtenerDatos("select " + Campos + "From HistorialVacunas where " + Condicion + Orden);
        }
    }
}
