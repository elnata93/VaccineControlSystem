using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Ciudades : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int CiudadId { get; set; }
        public string Descripcion { get; set; }

        public Ciudades()
        {
            this.CiudadId = 0;
            this.Descripcion = "";
        }

        public Ciudades(int ciudadId, string descripcion)
        {
            this.CiudadId = ciudadId;
            this.Descripcion = descripcion;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("insert into Ciudades(Descripcion) values('{0}') ", this.Descripcion));
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
                retorno = conexion.Ejecutar(String.Format("update Ciudades set Descripcion = '{0}' where CiudadId = {1} ", this.Descripcion,this.CiudadId));
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
                retorno = conexion.Ejecutar(String.Format("delete from Ciudades where CiudadId={0}", this.CiudadId));
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
            try
            {
                data = conexion.ObtenerDatos(String.Format("select * from Ciudades where CiudadId= " + IdBuscado));
                if (data.Rows.Count > 0)
                {
                    this.CiudadId = (int)data.Rows[0]["CiudadId"];
                    this.Descripcion = data.Rows[0]["Descripcion"].ToString();
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
            if (!Orden.Equals(""))
                ordenFinal = " Order by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From Ciudades Where " + Condicion + Orden);
        }

        public static DataTable Imprimir(string filtro = "1=1")
        {
            DataTable dt = new DataTable();
            ConexionDb conexion = new ConexionDb();
            dt = conexion.ObtenerDatos("Select * from Recepcion.Ciudades() Where  Descripcion Like '%" + filtro + "%'");
            return dt;
        }
    }
}
        
