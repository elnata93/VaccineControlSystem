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
        public int Sexo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int EsUnica { get; set; }
        public List<PacientesVacunas> PacienteVacuna { get; set; }

        public Pacientes()
        {
            this.PacienteId = 0;
            this.Nombres = "";
            this.Apellidos = "";
            this.Edad = 0;
            this.Sexo = 0;
            this.Direccion = "";
            this.EsUnica = 0;

            PacienteVacuna = new List<PacientesVacunas>();
        }

        public void AgregarVacunas(int vacunaId,string nombresVacunas)
        {
            PacienteVacuna.Add(new PacientesVacunas(vacunaId, nombresVacunas));
        }

        public Pacientes(int pacienteId,string nombres,string apellidos,int edad,int sexo,string direccion,string telefono,int esUnica)
        {
            this.PacienteId = pacienteId;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.EsUnica = esUnica;
        }
        
        public override bool Insertar()
        {
            int retorno = 0;
            object identity;
            try
            {
                identity = conexion.ObtenerValor(String.Format("Insert Into Pacientes(Nombres,Apellidos,Edad,Sexo,Direccion,Telefono,EsUnica) values('{0}','{1}',{2},{3},'{4}','{5}',{6}) select @@Identity ",
                    this.Nombres,this.Apellidos,this.Edad,this.Sexo,this.Direccion,this.Telefono,this.EsUnica));

                int.TryParse(identity.ToString(), out retorno);
                this.PacienteId = retorno;
                foreach (PacientesVacunas item in PacienteVacuna)
                {
                    conexion.Ejecutar(String.Format("Insert Into PacientesVacunas(PacienteId,VacunaId,NombresVacunas) values({0},{1},'{2}') ", retorno,item.VacunaId,item.NombresVacunas));
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
                retorno = conexion.Ejecutar(String.Format("update Pacientes set Nombres='{0}',Apellidos='{1}',Edad={2},Sexo={3},Direccion='{4}',Telefono='{5}',EsUnica = {6} where PacienteId = {7} ",
                    this.Nombres, this.Apellidos,this.Edad,this.Sexo,this.Direccion, this.Telefono,this.EsUnica,this.PacienteId ));
                if (retorno)
                {
                    conexion.Ejecutar(String.Format("delete from PacientesVacunas where PacienteId = {0} ", this.PacienteId));
                    foreach (PacientesVacunas item in PacienteVacuna)
                    {
                        conexion.Ejecutar(String.Format("Insert Into PacientesVacunas(PacienteId,VacunaId,NombresVacunas) values({0},{1},'{2}') ", this.PacienteId,item.VacunaId,item.NombresVacunas));
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
            data = conexion.ObtenerDatos(String.Format("select * from Pacientes where PacienteId= " + IdBuscado));

            if (data.Rows.Count > 0)
            {
                this.PacienteId = (int)data.Rows[0]["PacienteId"];
                this.Nombres = data.Rows[0]["Nombres"].ToString();
                this.Apellidos = data.Rows[0]["Apellidos"].ToString();
                this.Edad = (int)data.Rows[0]["Edad"];
                this.Sexo = (int)data.Rows[0]["Sexo"];
                this.Direccion = data.Rows[0]["Direccion"].ToString();
                this.Telefono = data.Rows[0]["Telefono"].ToString();
                this.EsUnica = (int)data.Rows[0]["EsUnica"];
                dt = conexion.ObtenerDatos(String.Format("Select * from PacientesVacunas where PacienteId= " + IdBuscado));
                foreach (var item in dt.Rows)
                {
                    this.AgregarVacunas((int)dt.Rows[0]["VacunaId"],dt.Rows[0]["NombresVacunas"].ToString());
                }
            }
            return data.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!ordenFinal.Equals(""))
            ordenFinal = " Order by " + Orden;
            //return conexion.ObtenerDatos(" select " + Campos + " From Pacientes where " + Condicion + Orden);

            return conexion.ObtenerDatos(" select p.PacienteId,p.Nombres,p.Apellidos,p.Edad,p.Sexo,p.Direccion,p.Telefono,p.EsUnica ,pv.PacienteVacunaId,pv.VacunaId,pv.NombresVacunas From Pacientes p inner join PacientesVacunas pv on p.PacienteId=pv.PacienteVacunaId where " + Condicion + Orden);

        }

    }
}
