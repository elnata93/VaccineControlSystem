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
        HistorialVacuna historial = new HistorialVacuna();
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
            dt = pVacuna.Listado("PacienteId", "0=0", "ORDER BY PacienteId");
            PacientescomboBox.DataSource = dt;
            PacientescomboBox.ValueMember = "PacienteId";
            PacientescomboBox.DisplayMember = "PacienteId";
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
            Eliminarbutton.Enabled = false;
        }

        private void LlenarCampos()
        {
            int bus = Convert.ToInt32(IdtextBox.Text);
            if (historial.Buscar(bus))
            {
                CentroSaludtextBox.Text = historial.CentroSalud;
                ProvinciatextBox.Text = historial.Provincia;
                MunicipiotextBox.Text = historial.Municipio;
                foreach (var item in historial.HistorialDosis)
                {
                    HistorialVacunadataGridView.Rows.Add(Convert.ToString(item.PacienteVacunaId), Convert.ToString(item.VacunaId), item.NombresVacunas, item.Dosis, item.FechaVacuna);
                }
                FechaHistorialdateTimePicker.Text = historial.FechaHistorial;
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text == "")
            {
                HistorialPacienteerrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                HistorialPacienteerrorProvider.Clear();
            }
            if(IdtextBox.Text.Length > 0)
            {
                if (historial.Buscar(int.Parse(IdtextBox.Text)))
                {
                    LlenarCampos();
                }
                Buscarbutton.Enabled = false;
                Guardarbutton.Text = "Modicar";
                Eliminarbutton.Enabled = true;
            }
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
            Guardarbutton.Text = "Guardar";
            Buscarbutton.Enabled = true;
            Eliminarbutton.Enabled = false;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenarDatos()
        {
            historial.CentroSalud = CentroSaludtextBox.Text;
            historial.Provincia = ProvinciatextBox.Text;
            historial.Municipio = MunicipiotextBox.Text;
            foreach (DataGridViewRow row in HistorialVacunadataGridView.Rows)
            {
                historial.AgregarDosis((int)row.Cells["PacienteVacunaId"].Value, (int)row.Cells["VacunaId"].Value,row.Cells["NombresVacunas"].Value.ToString(),row.Cells["Dosis"].Value.ToString(), Convert.ToString(row.Cells["FechaVacuna"].Value).ToString());
            }
            historial.FechaHistorial = FechaHistorialdateTimePicker.Text; 
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (CentroSaludtextBox.Text.Length == 0 || ProvinciatextBox.Text.Length == 0 || MunicipiotextBox.Text.Length == 0 || PacientescomboBox.Text.Length == 0 || VacunaPacientecomboBox.Text.Length == 0 || DosisvacunacomboBox.Text.Length == 0 || HistorialVacunadataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                LlenarDatos();
            if (IdtextBox.TextLength == 0)
            {
                if (historial.Insertar())
                {
                    MessageBox.Show("Historial Guardado");
                }
                else
                {
                    MessageBox.Show("Error al Guardar el Historial");
                }
                Limpiar();
            }
            else
            {
                LlenarDatos();
                if (IdtextBox.TextLength > 0)
                {
                    if (historial.Editar())
                    {
                        MessageBox.Show("Historial Editado");
                    }
                    else
                    {
                        MessageBox.Show("Error al Editar el Historial");
                    }
                    Limpiar();
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.TextLength > 0)
            {
                if (historial.Eliminar())
                {
                    MessageBox.Show("Historial Eliminado");
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Historial");
                }
            }
            Limpiar();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            HistorialVacunadataGridView.Rows.Add(PacientescomboBox.SelectedValue, VacunaPacientecomboBox.SelectedValue,VacunaPacientecomboBox.Text, DosisvacunacomboBox.Text, FechaVacunadateTimePicker.Text);
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
