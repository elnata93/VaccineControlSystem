using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PacientesVacunas
    {
        ConexionDb conexion = new ConexionDb();
        public int PacienteVacunaId { get; set; }
        public string NombresPacientes { get; set; }
        public int VacunaId { get; set; }
        public string  NombresVacunas { get; set; }

        public PacientesVacunas()
        {
            this.PacienteVacunaId = 0;
            this.VacunaId = 0;
            this.NombresVacunas = "";
        }
        
        public PacientesVacunas( int vacunaId, string nombresVacunas)
        {
            this.VacunaId = vacunaId;
            this.NombresVacunas = nombresVacunas;
        }

        public DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From PacientesVacunas Where " + Condicion + Orden);
        }
    }
}
