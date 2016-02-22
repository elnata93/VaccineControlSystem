using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Usuarios : ClaseMaestra
    {

        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }
        public int TipoUsuarioId { get; set; }
        public int CiudadId { get; set; }

        ConexionDb conexion = new ConexionDb();

        public Usuarios()
        {

        }

        public Usuarios(int usuarioId, string nombre, string apellido, string direccion, string telefono, string contrasena, int tipoUsuarioId, int ciudadId)
        {
            this.UsuarioId = usuarioId;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Contrasena = contrasena;
            this.TipoUsuarioId = tipoUsuarioId;
            this.CiudadId = ciudadId;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("insert into Usuarios(Nombre,Apellido,Direccion,Telefono,Contrasena,TipoUsuarioId,CiudadId values('{0}','{1}','{2}','{3}','{4}',{5},{6}) ",
                    this.Nombre, this.Apellido, this.Direccion, this.Telefono,this.Contrasena,this.TipoUsuarioId,this.CiudadId));
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("update Usuarios set Nombre='{0}',Apellido='{1}',Direccion='{2}',Telefono='{3}',Contrasena='{4}',TipoUsuarioId={5},CiudadId={6} ",
                    this.Nombre, this.Apellido, this.Direccion, this.Telefono, this.Contrasena, this.TipoUsuarioId, this.CiudadId));
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("delete from Usuarios where UsuarioId = {0} ",this.UsuarioId));
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable datatable = new DataTable();
            try
            {
                datatable = conexion.ObtenerDatos(string.Format("select * from Usuarios where UsuarioId= '" + IdBuscado + "'"));
                if (datatable.Rows.Count > 0)
                {
                    
                    this.UsuarioId = (int)datatable.Rows[0]["UsuarioId"];
                    this.Nombre = datatable.Rows[0]["Nombres"].ToString();
                    this.Apellido = datatable.Rows[0]["Apellidos"].ToString();
                    this.Direccion = datatable.Rows[0]["Direccion"].ToString();
                    this.Telefono = datatable.Rows[0]["Telefono"].ToString(); 
                    this.Contrasena = datatable.Rows[0]["Contrasena"].ToString();
                    this.TipoUsuarioId = (int)datatable.Rows[0]["TipoUsuarioId"];
                    this.CiudadId = (int)datatable.Rows[0]["CiudadId"];
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return datatable.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From Usuarios Where " + Condicion + Orden);
        }
    }
}