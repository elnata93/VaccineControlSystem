using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccineControlSystem
{
    public partial class VaccineControlSystem : Form
    {
        public VaccineControlSystem()
        {
            InitializeComponent();
        }

        private void VaccineControlSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.UsuariosForm usuario = new Registros.UsuariosForm();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void ConsultaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuariosForm consul = new Consultas.ConsultaUsuariosForm();
            consul.MdiParent = this;
            consul.Show();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.CiudadesForm ciudad = new Registros.CiudadesForm();
            ciudad.MdiParent = this;
            ciudad.Show();
        }

        private void ciudadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaCiudadesForm ciudad = new Consultas.ConsultaCiudadesForm();
            ciudad.MdiParent = this;
            ciudad.Show();
        }

        private void vacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.VacunasForm vacuna = new Registros.VacunasForm();
            vacuna.MdiParent = this;
            vacuna.Show();
        }

        private void vacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaVacunasForm vacuna = new Consultas.ConsultaVacunasForm();
            vacuna.MdiParent = this;
            vacuna.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.PacientesForm paciente = new Registros.PacientesForm();
            paciente.MdiParent = this;
            paciente.Show();

        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaPacientesForm paciente = new Consultas.ConsultaPacientesForm();
            paciente.MdiParent = this;
            paciente.Show();
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
