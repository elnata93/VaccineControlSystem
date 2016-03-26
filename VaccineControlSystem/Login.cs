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

namespace VaccineControlSystem
{
    public partial class Login : Form
    {
        Usuarios use = new Usuarios();
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public Login()
        {
            InitializeComponent();
            this.Usuario = "";
            this.Contrasena = "";
        }

        public Login(string usuario, string contrasena)
        {
            this.Usuario = usuario;
            this.Contrasena = contrasena;
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (use.Login(NombreUsuariotextBox.Text, ContrasenatextBox.Text) == true)
            {
                VaccineControlSystem vcs = new VaccineControlSystem();
                vcs.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectas");
            }
        }

        private void Cacelarbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
