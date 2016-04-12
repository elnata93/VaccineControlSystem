using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class HistorialDetalle
    {
        ConexionDb conexion = new ConexionDb();
        public int HistorialDetalleId { get; set; }
        public int PacienteVacunaId { get; set; }
        public int VacunaId { get; set; }
        public string NombresVacunas { get; set; }
        public string Dosis{ get; set; }
        public string FechaVacuna { get; set; }

        public HistorialDetalle()
        {
            this.PacienteVacunaId = 0;
            this.VacunaId = 0;
            this.NombresVacunas = "";
            this.Dosis = "";
            this.FechaVacuna = "";
        }
        public HistorialDetalle(int pacienteVacunaId,int vacunaId,string nombresVacunas,string dosis,string fechaVacuna)
        {
            this.PacienteVacunaId = pacienteVacunaId;
            this.VacunaId = vacunaId;
            this.NombresVacunas = nombresVacunas;
            this.Dosis = dosis;
            this.FechaVacuna = fechaVacuna;
        }

        public DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From HistorialDetalle Where " + Condicion + Orden);
        }
    }
}
