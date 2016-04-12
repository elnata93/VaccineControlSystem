using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HistorialVacuna : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();
        public int HistorialVacunaId { get; set; }
        public string CentroSalud { get; set; }
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        public string FechaHistorial { get; set; }
        public List<HistorialDetalle> HistorialDosis { get; set; }

        public HistorialVacuna()
        {
            this.HistorialVacunaId = 0;
            this.CentroSalud = "";
            this.Provincia = "";
            this.Municipio = "";
            this.FechaHistorial = "";
            HistorialDosis = new List<HistorialDetalle>();
        }

        public HistorialVacuna(int historialVacunaId, string centroSalud, string provincia, string municipio,string fechaHistorial)
        {
            this.HistorialVacunaId = historialVacunaId;
            this.CentroSalud = CentroSalud;
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.FechaHistorial = fechaHistorial;
        }

        public void AgregarDosis(int pacienteVacunaId, int vacunaId,string nombresVacunas, string dosis, string fechaVacuna)
        {
            HistorialDosis.Add(new HistorialDetalle (pacienteVacunaId, vacunaId,nombresVacunas,dosis, fechaVacuna));
        }

        public override bool Insertar()
        {
            //bool retorno = false;
            //try
            //{
            //    retorno = conexion.Ejecutar(String.Format("Insert Into HistorialVacunas(CentroSalud, Provincia, Municipio,PacienteId, PacienteVacunaId,NombresVacunas,Dosis,FechaVacuna,FechaHistorial) values('{0}','{1}','{2}',{3},{4},'{5}','{6}','{7}','{8}')",
            //        this.CentroSalud,this.Provincia,this.Municipio,this.PacienteId,this.PacienteVacunaId,this.NombresVacunas,this.FechaVacuna,this.Dosis,this.FechaHistorial));
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //return retorno;

            int retorno = 0;
            object identity;
            try
            {
                identity = conexion.ObtenerValor(String.Format("Insert Into HistorialVacunas(CentroSalud, Provincia, Municipio, FechaHistorial) values('{0}','{1}','{2}','{3}') Select @@Identity",
                        this.CentroSalud,this.Provincia,this.Municipio,this.FechaHistorial));

                int.TryParse(identity.ToString(), out retorno);
                this.HistorialVacunaId= retorno;
                if (retorno>0)
                {
                        foreach (HistorialDetalle item in HistorialDosis)
                        {
                            conexion.Ejecutar(String.Format("Insert Into HistorialDetalle(HistorialVacunaId ,PacienteVacunaId, VacunaId, NombresVacunas, Dosis, FechaVacuna) values({0},{1},{2},'{3}','{4}','{5}') ", retorno, item.PacienteVacunaId, item.VacunaId, item.NombresVacunas, item.Dosis, item.FechaVacuna));
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                //retorno = conexion.Ejecutar(String.Format("update HistorialVacuna set CentroSalud='{0}', Provincia='{1}', Municipio='{2}',PacienteId={3}, Dosis='{4}' where HistorialVacunaId={10}) ",
                //    this.CentroSalud, this.Provincia, this.Municipio, this.PacienteId, this.Dosis,this.HistorialVacunaId));
                if (retorno)
                {
                    conexion.Ejecutar(String.Format("delete form HistorialDetalle where HistorialVacunaId = {0} ", this.HistorialVacunaId));
                    foreach(HistorialDetalle item in HistorialDosis)
                    {
                        conexion.Ejecutar(String.Format("Insert Into HistorialDetalle(PacienteVacunaId, VacunaId, NombresVacunas, Dosis, FechaVacuna) values({0},{1},'{2}','{3}','{4}') ", item.PacienteVacunaId, item.VacunaId, item.NombresVacunas, item.Dosis, item.FechaVacuna));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;

            //bool retorno = false;
            //try
            //{
            //    retorno = conexion.Ejecutar(String.Format("update Pacientes set Nombres='{0}',Apellidos='{1}',Edad={2},Sexo={3},Direccion='{4}',Telefono='{5}',EsUnica = {6} where PacienteId = {7} ",
            //        this.Nombres, this.Apellidos, this.Edad, this.Sexo, this.Direccion, this.Telefono, this.EsUnica, this.PacienteId));
            //    if (retorno)
            //    {
            //        conexion.Ejecutar(String.Format("delete from PacientesVacunas where PacienteId = {0} ", this.PacienteId));
            //        foreach (PacientesVacunas item in PacienteVacuna)
            //        {
            //            conexion.Ejecutar(String.Format("Insert Into PacientesVacunas(PacienteId,VacunaId,NombresVacunas) values({0},{1},'{2}') ", this.PacienteId, item.VacunaId, item.NombresVacunas));
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //return retorno;
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
                dt = conexion.ObtenerDatos(String.Format("Select * from HistorialDetalle where HistorialVacunaId= " + IdBuscado));
                foreach (var item in dt.Rows)
                {
                    this.AgregarDosis((int)dt.Rows[0]["PacienteVacunaId"], (int)dt.Rows[0]["VacunaId"],dt.Rows[0]["NombresVacunas"].ToString(),dt.Rows[0]["Dosis"].ToString(),dt.Rows[0]["FechaVacuna"].ToString());
                }

            }

            return data.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!ordenFinal.Equals(""))
                ordenFinal = " Order by " + Orden;
            //return conexion.ObtenerDatos("select " + Campos + "From HistorialVacunas where " + Condicion + Orden);
            return conexion.ObtenerDatos(" select hv.HistorialVacunaId,hv.CentroSalud,hv.Provincia,hv.Municipio,dh.PacienteVacunaId,dh.VacunaId,dh.NombresVacunas,dh.Dosis,dh.FechaVacuna From HistorialVacunas hv inner join HistorialDetalle dh on hv.HistorialVacunaId=dh.HistorialDetalleId where " + Condicion + Orden);

        }
    }
}
