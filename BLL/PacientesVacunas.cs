using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PacientesVacunas
    {
        public int PacienteVacunaId { get; set; }
        public int PacienteId { get; set; }
        public int VacunaId { get; set; }

        public PacientesVacunas()
        {
            this.PacienteVacunaId = 0;
            this.PacienteId = 0;
            this.VacunaId = 0;
        }
        
        public PacientesVacunas(int pacienteId,int vacunaId)
        {
            this.PacienteId = pacienteId;
            this.VacunaId = vacunaId;
        }

    }
}
