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
        public int  TiposUsuarios { get; set; }
        public string Contrasena { get; set; }

        public Login()
        {
            InitializeComponent();
            this.Usuario = "";
            this.TiposUsuarios = 0;
            this.Contrasena = "";
        }

        public Login(string usuario, int tipoUsuario,string contrasena)
        {
            this.Usuario = usuario;
            this.TiposUsuarios = tipoUsuario;
            this.Contrasena = contrasena;
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (use.Login(NombreUsuariotextBox.Text,TipoUsuariocomboBox.SelectedIndex, ContrasenatextBox.Text) == true)
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

        private void Login_Load(object sender, EventArgs e)
        {
            TiposUsuarios tUser = new TiposUsuarios();
            DataTable dt = new DataTable();
            dt = tUser.Listado("TipoUsuarioId,Descripcion", "0=0", "ORDER BY TipoUsuarioId");
            TipoUsuariocomboBox.DataSource = dt;
            TipoUsuariocomboBox.ValueMember = "TipoUsuarioId";
            TipoUsuariocomboBox.DisplayMember = "Descripcion";

        }
    }
}
