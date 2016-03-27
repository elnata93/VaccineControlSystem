using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TiposUsuarios : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int TipoUsuarioId { get; set; }     
        public string Descripcion { get; set; }

        public TiposUsuarios()
        {
            this.TipoUsuarioId = 0;
            this.Descripcion = "";
        }

        public TiposUsuarios(int tipoUsuarioId,string descripcion)
        {
            this.TipoUsuarioId = tipoUsuarioId;
            this.Descripcion = descripcion;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("insert into TiposUsuarios(Descripcion) values('{0}') ",this.Descripcion));
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
                retorno = conexion.Ejecutar(String.Format("update TiposUsuarios set Descripcion = '{0}' where TipoUsuarioId = {1} ", this.Descripcion,this.TipoUsuarioId));
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
                retorno = conexion.Ejecutar(String.Format("delete from TiposUsuarios where TipoUsuarioId = {0} ", this.Descripcion));
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
                data = conexion.ObtenerDatos(String.Format("select * from TiposUsuarios where TipoUsuarioId= " + IdBuscado));
                if (data.Rows.Count > 0)
                {
                    this.TipoUsuarioId = (int)data.Rows[0]["TipoUsuarioId"];
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
                ordenFinal = " Orden by  " + Orden;
            return conexion.ObtenerDatos("Select " + Campos + " From TiposUsuarios Where " + Condicion + Orden);
        }
    }
}
