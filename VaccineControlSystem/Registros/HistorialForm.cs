using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace VaccineControlSystem.Registros
{
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
        }
        PacientesVacunas pVacuna = new PacientesVacunas();
        Pacientes pacientes = new Pacientes();
        private void LlenarComboboxVacunaPaciente()
        {
            DataTable data = new DataTable();
            data = pVacuna.Listado("PacienteVacunaId,NombresVacunas", "0=0", "ORDER BY PacienteVacunaId");
            VacunaPacientecomboBox.DataSource = data;
            VacunaPacientecomboBox.ValueMember = "PacienteVacunaId";
            VacunaPacientecomboBox.DisplayMember = "NombresVacunas";
        }

        private void LlenarComboboxPaciente()
        {
            DataTable dt= new DataTable();
            dt = pacientes.Listado("PacienteId,Nombres", "0=0", "ORDER BY PacienteId");
            PacientescomboBox.DataSource = dt;
            PacientescomboBox.ValueMember = "PacienteId";
            PacientescomboBox.DisplayMember = "Nombres";
        }
        
        private void HabilitarButtonEliminar()
        {
            if (IdtextBox.Text != "")
                Eliminarbutton.Enabled = true;
            else
                Eliminarbutton.Enabled = false;
        }
        
        private void HistorialForm_Load(object sender, EventArgs e)
        {
            LlenarComboboxVacunaPaciente();
            LlenarComboboxPaciente();
            HabilitarButtonEliminar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }


        private void Limpiar()
        {
            IdtextBox.Clear();
            CentroSaludtextBox.Clear();
            ProvinciatextBox.Clear();
            MunicipiotextBox.Clear();
            PacientescomboBox.ResetText();
            VacunaPacientecomboBox.ResetText();
            DosisvacunacomboBox.ResetText();
            FechaVacunadateTimePicker.ResetText();
            HistorialVacunadataGridView.Rows.Clear();
            FechaHistorialdateTimePicker.ResetText();
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void CentroSaludtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ProvinciatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void MunicipiotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
