using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace BLL
{
    public class Vacunas : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int VacunaId { get; set; }
        public string NombresVacunas { get; set; }

        public Vacunas()
        {
            this.VacunaId = 0;
            this.NombresVacunas = "";
        }

        public Vacunas(int vacunaId,string nombresVacunas)
        {
            this.VacunaId = vacunaId;
            this.NombresVacunas = nombresVacunas;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert into Vacunas(NombresVacunas) values('{0}') ", this.NombresVacunas));
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
                retorno = conexion.Ejecutar(String.Format("Update Vacunas set NombresVacunas = '{0}' ", this.NombresVacunas));
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
                retorno = conexion.Ejecutar(String.Format("Delete from Vacunas where VacunaId = {0} ", this.VacunaId));
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
            data = conexion.ObtenerDatos(String.Format("Select * from Vacunas where VacunaId= " + IdBuscado));
            try
            {
                if (data.Rows.Count > 0)
                {
                    this.VacunaId = (int)data.Rows[0]["VacunaId"];
                    this.NombresVacunas = data.Rows[0]["NombresVacunas"].ToString();
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
                ordenFinal = "Order by " + Orden;
            return conexion.ObtenerDatos("Select " + Campos + " From Vacunas where " + Condicion + Orden);
        }

        public static DataTable Imprimir(string filtro = "1=1")
        {
            DataTable dt = new DataTable();
            ConexionDb conexion = new ConexionDb();
            dt = conexion.ObtenerDatos("Select * from Recepcion.Vacunas() Where  Descripcion Like '%" + filtro + "%'");
            return dt;
        }

        //public bool Existe(int id)
        //{
        //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["VacunaId"].ToString()))
        //    {
        //        string query = "SELECT COUNT(*) FROM Vacunas WHERE VacunaId=@Id";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("Id", id);
        //        conn.Open();
        //
        //        int count = Convert.ToInt32(cmd.ExecuteScalar());
        //        if (count == 0)
        //            return false;
        //        else
        //            return true;
        //    }
        //}
    }
}
