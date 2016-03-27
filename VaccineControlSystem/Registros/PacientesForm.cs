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

        private void LlenarComboboxVacuna()
        {
            DataTable data = new DataTable();
            data = paciente.Listado("VacunaId,NombresVacunas", "0=0", "ORDER BY VacunaId");
            VacunacomboBox.DataSource = data;
            VacunacomboBox.ValueMember = "VacunaId";
            VacunacomboBox.DisplayMember = "NombresVacunas";
        }
        
        private void PacientesForm_Load(object sender, EventArgs e)
        {
            LlenarComboboxVacuna();
        }

        public void LlenarCampos()
        {
            int bus = Convert.ToInt32(IdtextBox.Text);
            if (paciente.Buscar(bus))
            {
                NombretextBox.Text = paciente.Nombres;
                ApellidotextBox.Text = paciente.Apellidos;
                EdadtextBox.Text = paciente.Edad.ToString();


                DirecciontextBox.Text = paciente.Direccion;
                TelefonomaskedTextBox.Text = paciente.Telefono;


                VacunacomboBox.Text = paciente.VacunaId.ToString();
                foreach (var item in paciente.PacienteVacuna)
                {
                    VacunadataGridView.Rows.Add(item.VacunaId);
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

        public void Limpiar()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            EdadtextBox.Clear();
            MasculinoradioButton.ResetText();
            FemeninoradioButton.ResetText();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            SiradioButton.ResetText();
            NoradioButton.ResetText();
            VacunacomboBox.ResetText();
            VacunadataGridView.Rows.Clear();

        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void LlenarDatos()
        {
            int id;
            int.TryParse(IdtextBox.Text, out id);
            paciente.Nombres = NombretextBox.Text;
            paciente.Apellidos = ApellidotextBox.Text;
            paciente.Edad = (int)Convert.ToInt32(EdadtextBox.Text);
            if (paciente.Sexo == true)
            {
                MasculinoradioButton.Checked = true;
            }
            if(paciente.Sexo == false)
            {
                FemeninoradioButton.Checked = false;
            }
            paciente.Direccion = DirecciontextBox.Text;
            paciente.Telefono = TelefonomaskedTextBox.Text;
            if (paciente.EsUnica == true)
            {
                SiradioButton.Checked = true;
            }
            if (paciente.EsUnica == false)
            {
                NoradioButton.Checked = false;
            }
            for(int i=0; i<VacunadataGridView.Rows.Count; i++)
            {
                paciente.AgregarVacunas(paciente.PacienteId, (int)Convert.ToInt32(VacunadataGridView.Rows[i].ToString()));
            }

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (NombretextBox.Text.Length == 0 || ApellidotextBox.Text.Length == 0 || EdadtextBox.Text.Length == 0 || DirecciontextBox.Text.Length == 0 || TelefonomaskedTextBox.Text.Length == 0 || VacunadataGridView.Rows.ToString() == "")
            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if(IdtextBox.TextLength == 0)
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
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.TextLength > 0)
            {
                
                paciente.PacienteId = int.Parse(IdtextBox.Text);

                if (paciente.Eliminar())
                {
                    MessageBox.Show("Paciente Eliminado");
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Paciente");
                }
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            VacunadataGridView.Rows.Add(VacunacomboBox.SelectedValue,VacunacomboBox.Text);
        }

        private void VacunagroupBox_Enter(object sender, EventArgs e)
        {
            LlenarComboboxVacuna();
        }
    }
}
