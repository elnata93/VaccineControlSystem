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
using System.Data.SqlClient;
using System.Configuration;

namespace VaccineControlSystem.Registros
{
    public partial class VacunasForm : Form
    {
        Vacunas vacuna = new Vacunas();
        public VacunasForm()
        {
            InitializeComponent();
        }

        public void LlenarCampos()
        {
            NombreVacunatextBox.Text = vacuna.NombresVacunas;
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (IdtextBox.Text == "")
            {
                VacunaerrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
                {
                    VacunaerrorProvider.Clear();
                }

            if (IdtextBox.Text.Length > 0)
            {
                if (vacuna.Buscar(int.Parse(IdtextBox.Text)))
                {
                    LlenarCampos();
                }
            }
            Eliminarbutton.Enabled = true;

            
        }

        public void Limpiar()
        {
            IdtextBox.Clear();
            NombreVacunatextBox.Clear();
            Eliminarbutton.Enabled = false;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void LlenarDatos()
        {
            int id = 0;
            int.TryParse(IdtextBox.Text, out id);
            vacuna.VacunaId = id;
            vacuna.NombresVacunas = NombreVacunatextBox.Text;
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            if (NombreVacunatextBox.Text.Length == 0)
            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (IdtextBox.TextLength == 0)
            {
                LlenarDatos();
                if (vacuna.Insertar())
                {
                    MessageBox.Show("Vacuna Guardada.");
                }
                else
                {
                    MessageBox.Show("Error al Guardar la Vacuna.");
                }
                Limpiar();
            }
            else
            if (IdtextBox.TextLength > 0)
            {
                LlenarDatos();
                if (vacuna.Editar())
                {
                    MessageBox.Show("Vacuna Editada.");
                }
                else
                {
                    MessageBox.Show("Error al Editar Vacuna.");
                }
                Limpiar();
            }
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Length == 0)
                {
                    MessageBox.Show("Debe especifiar el ID...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                if (IdtextBox.TextLength > 0)
                {
                    LlenarDatos();

                    if (vacuna.Eliminar())
                    {
                        MessageBox.Show("Vacuna Eliminada.");
                    }
                    else
                    {
                        MessageBox.Show("Error no se Puede Eliminar la Vacuna.");
                    }
                    Limpiar();
                }
        }

        private void IdtextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DescripciontextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void VacunasForm_Load(object sender, EventArgs e)
        {
            if ((IdtextBox.Text != ""))
                Eliminarbutton.Enabled = true;
            else
                Eliminarbutton.Enabled = false;
        }
    }
}

