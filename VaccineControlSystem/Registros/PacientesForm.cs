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
    public partial class PacientesForm : Form
    {
        public PacientesForm()
        {
            InitializeComponent();
        }

        Vacunas vacuna = new Vacunas();
        Pacientes paciente = new Pacientes();

        public void LlenarComboboxVacuna()
        {
            DataTable data = new DataTable();
            data = vacuna.Listado("VacunaId,NombresVacunas", "0=0", "ORDER BY VacunaId");
            VacunacomboBox.DataSource = data;
            VacunacomboBox.ValueMember = "VacunaId";
            VacunacomboBox.DisplayMember = "NombresVacunas";
        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {
            LlenarComboboxVacuna();

            if (IdtextBox.Text != "")
                Eliminarbutton.Enabled = true;
            else
                Eliminarbutton.Enabled = false;
        }

        public void LlenarCampos()
        {
            int bus = Convert.ToInt32(IdtextBox.Text);
            if (paciente.Buscar(bus))
            {
                NombretextBox.Text = paciente.Nombres;
                ApellidotextBox.Text = paciente.Apellidos;
                EdadtextBox.Text = paciente.Edad.ToString();
                if (paciente.Sexo == 0)
                {
                    MasculinoradioButton.Checked = true;
                }else
                if (paciente.Sexo == 1)
                {
                    FemeninoradioButton.Checked = false;
                }
                DirecciontextBox.Text = paciente.Direccion;
                TelefonomaskedTextBox.Text = Convert.ToString(paciente.Telefono);
                if (paciente.EsUnica == 0)
                {
                    SiradioButton.Checked = true;
                }else
                if (paciente.EsUnica == 1)
                {
                    NoradioButton.Checked = false;
                }
                foreach (var item in paciente.PacienteVacuna)
                {
                    VacunadataGridView.Rows.Add(Convert.ToString(item.VacunaId),item.NombresVacunas);
                    VacunadataGridView.AutoGenerateColumns = false;
                }
            }
        }

       
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text == "")
            {
                PacienteerrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                PacienteerrorProvider.Clear();
            }
            if (IdtextBox.Text.Length > 0)
            {
                if (paciente.Buscar(int.Parse(IdtextBox.Text)))
                {
                    LlenarCampos();
                }
            }
        }

        private void Limpiar()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            EdadtextBox.Clear();
            MasculinoradioButton.Checked = false;
            FemeninoradioButton.Checked = false;
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            VacunacomboBox.ResetText();
            VacunadataGridView.Rows.Clear();
            PacienteerrorProvider.Clear();
            SiradioButton.Checked = false;
            NoradioButton.Checked = false;

        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private int ConvertirEntero(string numero)
        {
            int num;
            int.TryParse(numero, out num);
            return num;
        }

        private void LlenarDatos()
        {
            int id;
            int.TryParse(IdtextBox.Text, out id);
            paciente.PacienteId = id;
            paciente.Nombres = NombretextBox.Text;
            paciente.Apellidos = ApellidotextBox.Text;
            paciente.Edad = Convert.ToInt32(EdadtextBox.Text);
            if (MasculinoradioButton.Checked == true)
            {
                paciente.Sexo = 0;
            }
            if(FemeninoradioButton.Checked == false)
            { 
                paciente.Sexo = 1;
            }
            paciente.Direccion = DirecciontextBox.Text;
            paciente.Telefono = TelefonomaskedTextBox.Text.ToString();
            if (SiradioButton.Checked == true)
            {
                paciente.EsUnica = 0;
            }
            if (NoradioButton.Checked == false)
            {
                paciente.EsUnica = 1;
            }
            foreach (DataGridViewRow row in VacunadataGridView.Rows)
            {
                paciente.AgregarVacunas((int)row.Cells["VacunaId"].Value,row.Cells["NombresVacunas"].Value.ToString());
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (NombretextBox.Text.Length == 0 || ApellidotextBox.Text.Length == 0 || EdadtextBox.Text.Length == 0 || DirecciontextBox.Text.Length == 0 || TelefonomaskedTextBox.Text.Length == 0 ||  VacunadataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (IdtextBox.TextLength == 0)
            {
                LlenarDatos();
                if (paciente.Insertar())
                {
                    MessageBox.Show("Pacientes Guardado");
                }
                else
                {
                    MessageBox.Show("Error al Guardar el Paciente");
                }
                Limpiar();
            }
            else
            {
                if (IdtextBox.TextLength > 0)
                {
                    LlenarDatos();
                    if (paciente.Editar())
                    {
                        MessageBox.Show("Pacientes Editado");
                    }
                    else
                    {
                        MessageBox.Show("Error al Editar el Paciente");
                    }
                    Limpiar();
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.TextLength > 0)
            {

                LlenarDatos();

                if (paciente.Eliminar())
                {
                    MessageBox.Show("Paciente Eliminado");
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Paciente");
                }
            }
            Limpiar();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            VacunadataGridView.Rows.Add(VacunacomboBox.SelectedValue, VacunacomboBox.Text);
        }

        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DirecciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void EdadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
