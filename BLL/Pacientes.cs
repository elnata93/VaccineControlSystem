using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Pacientes : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int PacienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public bool Sexo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int CiudadId { get; set; }
        public bool EsUnica { get; set; }
        public int VacunaId { get; set; }
        public List<PacientesVacunas> PacienteVacuna { get; set; }

        public Pacientes()
        {
            this.PacienteId = 0;
            this.Nombres = "";
            this.Apellidos = "";
            this.Edad = 0;
            this.Sexo = true;
            this.Direccion = "";
            this.Telefono = "";
            this.EsUnica = true;
            this.VacunaId = 0;
            PacienteVacuna = new List<PacientesVacunas>();
        }

        public void AgregarVacunas(int pacienteId, int vacunaId)
        {
            PacienteVacuna.Add(new PacientesVacunas(PacienteId, VacunaId));
        }

        public Pacientes(int pacienteId,string nombres,string apellidos,int edad,bool sexo,string direccion,string telefono,bool esunica,int vacunaId)
        {
            this.PacienteId = pacienteId;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.EsUnica = esunica;
            this.VacunaId = vacunaId;
        }
        
        public override bool Insertar()
        {
            bool retorno = false;
            object identity;
            try
            {
                identity = conexion.Ejecutar(String.Format("Insert Into Pacientes(Nombres,Apllidos,Edad,Sexo,Direccion,Telefono,EsUnica,VacunaId) values('{0}','{1}',{2},{3},'{4}','{5}',{6},{7} ) select @@Identity ",
                    this.Nombres,this.Apellidos,this.Edad,this.Sexo,this.Direccion,this.Telefono,this.EsUnica,this.VacunaId));
                this.PacienteId = (int)identity;
                foreach (var item in PacienteVacuna)
                {
                    conexion.Ejecutar(String.Format("Insert Into PacientesVacunas(PacienteId,VacunaId,Descripcion) values({0},{1},{2}) ",this.PacienteId,item.VacunaId,item.Descripcion));
                }   
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
                retorno = conexion.Ejecutar(String.Format("update Pacientes set Nombres='{0}',Apllidos='{1}',Edad={2},Sexo={3},Direccion='{4}',Telefono='{5}',EsUnica={6},VacunaId={7}",
                    this.Nombres, this.Apellidos,this.Edad,this.Sexo,this.Direccion, this.Telefono, this.EsUnica, this.VacunaId));
                if (retorno)
                {
                    conexion.Ejecutar(String.Format("delete from PacientesVacunas where PacienteId = " + this.PacienteId));
                    foreach (var item in PacienteVacuna)
                    {
                        conexion.Ejecutar(String.Format("Insert Into PacientesVacunas(PacienteId,VacunaId,Descripcion) values({0},{1},{2}) ", this.PacienteId,item.VacunaId, item.Descripcion));
                    }
                }
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
                retorno = conexion.Ejecutar(String.Format("delete from Pacientes where PacienteId={0}" + "delete from PacientesVacunas where PacienteId={0}", this.PacienteId));

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
            data = conexion.ObtenerDatos(String.Format("select * from Pacientes where Paciente= " + IdBuscado));
            try
            {
                if (data.Rows.Count > 0)
                {
                    this.PacienteId = (int)data.Rows[0]["PacienteId"];
                    this.Nombres = data.Rows[0]["Nombres"].ToString();
                    this.Apellidos = data.Rows[0]["Apellidos"].ToString();
                    this.Edad = (int)data.Rows[0]["Edad"];
                    this.Sexo = (bool)data.Rows[0]["Sexo"];
                    this.Direccion = data.Rows[0]["Direccion"].ToString();
                    this.Telefono = data.Rows[0]["Telefono"].ToString();
                    this.EsUnica = (bool)data.Rows[0]["EsUnica"];
                    this.VacunaId = (int)data.Rows[0]["VacunaId"];
                    dt = conexion.ObtenerDatos(String.Format("Select * from PacientesVacunas where PacienteId = " + IdBuscado));
                    foreach (var item in PacienteVacuna)
                    {
                        AgregarVacunas(this.PacienteId, item.VacunaId);
                    }
                }
            }       
            catch (Exception ex)
            {
                throw ex;
            }
            return data.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!ordenFinal.Equals(""))
            ordenFinal = " Order by " + Orden;
            return conexion.ObtenerDatos("select " + Campos + "From Pacientes where " + Condicion + Orden);
        }
    }
}
