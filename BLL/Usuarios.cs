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
        ConexionDb conexion = new ConexionDb();

        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public int TipoUsuarioId { get; set; }
        public int CiudadId { get; set; }
        public string Fecha { get; set; }
        public string Imagen { get; set; }

        public Usuarios()
        {
            this.UsuarioId = 0;
            this.NombreUsuario = "";
            this.Nombres = "";
            this.Apellidos = "";
            this.Direccion = "";
            this.Telefono = "";
            this.Email = "";
            this.Contrasena = "";
            this.TipoUsuarioId = 0;
            this.CiudadId = 0;
            this.Fecha = "";
            this.Imagen = "";
        }

        public Usuarios(int usuarioId, string nombreUsuario,string nombre, string apellido, string direccion, string telefono, string email, string contrasena, int tipoUsuarioId, int ciudadId,string fecha,string imagen)
        {
            this.UsuarioId = usuarioId;
            this.NombreUsuario = nombreUsuario;
            this.Nombres = nombre;
            this.Apellidos = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Contrasena = contrasena;
            this.TipoUsuarioId = tipoUsuarioId;
            this.CiudadId = ciudadId;
            this.Fecha = fecha;
            this.Imagen = imagen;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("insert into Usuarios(NombresUsuarios,Nombres,Apellidos,Direccion,Telefono,Email,Contrasena,TipoUsuarioId,CiudadId,Fecha,Imagen) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},{8},'{9}','{10}') ",
                    this.NombreUsuario,this.Nombres, this.Apellidos, this.Direccion, this.Telefono,this.Email,this.Contrasena,this.TipoUsuarioId,this.CiudadId,this.Fecha,this.Imagen));  
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
                retorno = conexion.Ejecutar(String.Format("update Usuarios set NombresUsuarios = '{0}',Nombres = '{1}',Apellidos = '{2}',Direccion = '{3}',Telefono = '{4}',Email = '{5}',Contrasena = '{6}',TipoUsuarioId = {7},CiudadId = {8},Fecha = '{9}',Imagen = '{10}' where UsuarioId = {11} ",
                    this.NombreUsuario,this.Nombres, this.Apellidos, this.Direccion, this.Telefono,this.Email,this.Contrasena, this.TipoUsuarioId, this.CiudadId,this.Fecha,this.Imagen,this.UsuarioId));    
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
                retorno = conexion.Ejecutar(String.Format("delete from Usuarios where UsuarioId = {0} ",this.UsuarioId));
               
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
                data = conexion.ObtenerDatos(string.Format("select * from Usuarios where UsuarioId= " + IdBuscado));
                if (data.Rows.Count > 0)
                {
                    this.UsuarioId = (int)data.Rows[0]["UsuarioId"];
                    this.NombreUsuario = data.Rows[0]["NombresUsuarios"].ToString();
                    this.Nombres = data.Rows[0]["Nombres"].ToString();
                    this.Apellidos = data.Rows[0]["Apellidos"].ToString();
                    this.Direccion = data.Rows[0]["Direccion"].ToString();
                    this.Telefono = data.Rows[0]["Telefono"].ToString(); 
                    this.Contrasena = data.Rows[0]["Contrasena"].ToString();
                    this.Email = data.Rows[0]["Email"].ToString();
                    this.TipoUsuarioId = (int)data.Rows[0]["TipoUsuarioId"];
                    this.CiudadId = (int)data.Rows[0]["CiudadId"];
                    this.Fecha = data.Rows[0]["Fecha"].ToString();
                    this.Imagen = data.Rows[0]["Imagen"].ToString();
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

            return conexion.ObtenerDatos("Select " + Campos + " From Usuarios Where " + Condicion + Orden);
        }

        public static DataTable Imprimir(string filtro = "1=1")
        {
            DataTable dt = new DataTable();
            ConexionDb conexion = new ConexionDb();
            dt = conexion.ObtenerDatos("Select * from Recepcion.Usuarios() Where  Nombres Like '%" + filtro + "%'");
            return dt;
        }

        public bool Login(string nombre, string contrasena)
        {
            DataTable data = new DataTable();
            data = conexion.ObtenerDatos(String.Format("select  NombresUsuarios from Usuarios where NombresUsuarios = '{0}' and  Contrasena = '{1}'", nombre, contrasena));
            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}