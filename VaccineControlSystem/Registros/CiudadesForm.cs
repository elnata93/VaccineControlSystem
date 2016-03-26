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
    public partial class CiudadesForm : Form
    {
        Ciudades ciudad = new Ciudades();
        public CiudadesForm()
        {
            InitializeComponent();
        }

        public void LlenarCampos()
        {
            DescripciontextBox.Text = ciudad.Descripcion;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text == "")
            {
                CiudaderrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                CiudaderrorProvider.Clear();
            }
            if(IdtextBox.Text.Length > 0)
            {
                if (ciudad.Buscar(int.Parse(IdtextBox.Text)))
                {
                    LlenarCampos();
                }
            }
        }

        public void Limpiar()
        {
            IdtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        } 

        public void LlenarDatos()
        {
            ciudad.Descripcion = DescripciontextBox.Text;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (DescripciontextBox.Text.Length == 0 )
            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (IdtextBox.TextLength == 0)
            {
                LlenarDatos();
                if (ciudad.Insertar())
                {
                    MessageBox.Show("Ciudad Guardada.");
                }
                else
                {
                    MessageBox.Show("Error al Guardar la Ciudad.");
                }
                Limpiar();
            }
            else
            if (IdtextBox.TextLength > 0)
            {
                LlenarDatos();
                if (ciudad.Editar())
                {
                    MessageBox.Show("Ciudad Editada.");
                }
                else
                {
                    MessageBox.Show("Error al Editar Ciudad.");
                }
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe especifiar el ID...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (IdtextBox.TextLength > 0)
            {
                ciudad.CiudadId = int.Parse(IdtextBox.Text);

                if (ciudad.Eliminar())
                {
                    MessageBox.Show("Ciudad Eliminada.");
                }
                else
                {
                    MessageBox.Show("Error no se Puede Eliminar la Ciudad.");
                }
                Limpiar();
            }
        }

        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DescripciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
