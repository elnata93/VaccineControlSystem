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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        Usuarios usuario = new Usuarios();

        private void LlenarComboboxTipoUsuario()
        {
            DataTable datatable = new DataTable();
            TiposUsuarios tipo = new TiposUsuarios();
            datatable = tipo.Listado("TipoUsuarioId,Descripcion", "0=0", "ORDER BY TipoUsuarioId");
            TipoUsuariocomboBox.DataSource = datatable;
            TipoUsuariocomboBox.ValueMember = "TipoUsuarioId";
            TipoUsuariocomboBox.DisplayMember = "Descripcion";
        }
        
        private void LlenarComboboxCiudad()
        {
            DataTable data = new DataTable();
            Ciudades ciudad = new Ciudades();
            data = ciudad.Listado("CiudadId,Descripcion", "0=0", "ORDER BY CiudadId");
            CiudadcomboBox.DataSource = data;
            CiudadcomboBox.ValueMember = "CiudadId";
            CiudadcomboBox.DisplayMember = "Descripcion";
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            LlenarComboboxTipoUsuario();
            LlenarComboboxCiudad();

            if (IdtextBox.TextLength > 0)
                Eliminarbutton.Enabled = true;
            else
                Eliminarbutton.Enabled = false;
        }

        private void TryParse()
        {
            int Id = 0;
            int.TryParse(IdtextBox.Text, out Id);
        }

        private void ErProvider()
        {
            if (IdtextBox.Text.Trim() == "")
            {
                UsuarioerrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                UsuarioerrorProvider.Clear();
            }
        }

        public void LlenarCampos()
        {
            NombreUsuariotextBox.Text = usuario.NombreUsuario;
            NombretextBox.Text = usuario.Nombres;
            ApellidotextBox.Text = usuario.Apellidos;
            DirecciontextBox.Text = usuario.Direccion;
            TelefonomaskedTextBox.Text = usuario.Telefono;
            EmailtextBox.Text = usuario.Email;
            ContrasenatextBox.Text = usuario.Contrasena;
            TipoUsuariocomboBox.Text = usuario.TipoUsuarioId.ToString();
            CiudadcomboBox.Text = usuario.CiudadId.ToString();
            FechadateTimePicker.Text = usuario.Fecha;
            ImagenpictureBox.ImageLocation = usuario.Imagen;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text == "")
            {
                UsuarioerrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                UsuarioerrorProvider.Clear();
            }
            if(IdtextBox.Text.Length > 0)
            {
                if (usuario.Buscar(int.Parse(IdtextBox.Text)))
                {
                    LlenarCampos();
                }
            }
        }

        private void Limpiar()
        {
            IdtextBox.Clear();
            NombreUsuariotextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            EmailtextBox.Clear();
            ContrasenatextBox.Clear();
            TipoUsuariocomboBox.SelectedIndex = 0;
            CiudadcomboBox.SelectedIndex = 0;
            ImagenpictureBox.ImageLocation = null;
            UsuarioerrorProvider.Clear();
            FechadateTimePicker.ResetText();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private void LlenarDatos()
        {
            int id = 0;
            int.TryParse(IdtextBox.Text, out id);
            usuario.UsuarioId = id;
            usuario.NombreUsuario = NombreUsuariotextBox.Text;
            usuario.Nombres = NombretextBox.Text;
            usuario.Apellidos = ApellidotextBox.Text;
            usuario.Direccion = DirecciontextBox.Text;
            usuario.Telefono = TelefonomaskedTextBox.Text;
            usuario.Email = EmailtextBox.Text;
            usuario.Contrasena = ContrasenatextBox.Text;
            usuario.TipoUsuarioId = TipoUsuariocomboBox.SelectedIndex;
            usuario.CiudadId = CiudadcomboBox.SelectedIndex;
            usuario.Fecha = FechadateTimePicker.Text;
            usuario.Imagen = ImagenpictureBox.ImageLocation.ToString();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (NombreUsuariotextBox.Text.Length == 0 || NombretextBox.Text.Length == 0 || ApellidotextBox.Text.Length == 0 || DirecciontextBox.Text.Length == 0 || TelefonomaskedTextBox.Text.Length == 0 || EmailtextBox.Text.Length == 0 || ContrasenatextBox.Text.Length == 0 || TipoUsuariocomboBox.Text.Length == 0 || CiudadcomboBox.Text.Length == 0 || FechadateTimePicker.Text.Length == 0 || ImagenpictureBox.ImageLocation == null)
            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            if(IdtextBox.TextLength == 0)
            {
                LlenarDatos();
                if (usuario.Insertar())
                {
                    MessageBox.Show("Usuario Creado.");
                }
                else
                {
                    MessageBox.Show("Error al Crear el Usuario.");
                }
                Limpiar();
            }
            else 
            if(IdtextBox.TextLength > 0)
            {
                LlenarDatos();
                if (usuario.Editar())
                {
                    MessageBox.Show("Usuario Editado.");
                }
                else
                {
                    MessageBox.Show("Error al Editar Usuario.");
                }
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Length == 0 )
            {
                MessageBox.Show("Debe especifiar el ID...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            if (IdtextBox.TextLength > 0)
            {
                LlenarDatos();

                if (usuario.Eliminar())
                {
                    MessageBox.Show("Usuario Eliminado.");
                }
                else
                {
                    MessageBox.Show("Error no se Puede Eliminar el Usuario.");
                }
                Limpiar();
            }
        }

        private void Examinarbutton_Click(object sender, EventArgs e)
        {
            ImagenopenFileDialog.Filter = "Image Files| *.jpg; *.jpeg; *.png";
            ImagenopenFileDialog.ShowDialog();
            if (ImagenopenFileDialog.FileName != null)
            {
                ImagenpictureBox.ImageLocation = ImagenopenFileDialog.FileName;
            }
        }

        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void NombreUsuariotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163) || (e.KeyChar == 13))
                e.Handled = false;
            else
                e.Handled = true;
            if (e.KeyChar == 13)
            {
                NombretextBox.Focus();
            }
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

        private void EmailtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 45 && e.KeyChar <= 46) || (e.KeyChar == 95) || (e.KeyChar == 8) || (e.KeyChar >= 64 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ContrasenatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
