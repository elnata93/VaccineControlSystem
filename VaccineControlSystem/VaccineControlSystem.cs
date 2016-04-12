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
            Consultas.ConsultaUsuarios consul = new Consultas.ConsultaUsuarios();
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
            Consultas.ConsultaCiudades ciudad = new Consultas.ConsultaCiudades();
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
            Consultas.ConsultaVacunas vacuna = new Consultas.ConsultaVacunas();
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
            Consultas.ConsultaPacientes paciente = new Consultas.ConsultaPacientes();
            paciente.MdiParent = this;
            paciente.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.HistorialForm rhist = new Registros.HistorialForm();
            rhist.MdiParent = this;
            rhist.Show();
        }

        private void historialConsultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaHistorial rhist = new Consultas.ConsultaHistorial();
            rhist.MdiParent = this;
            rhist.Show();
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

        private void CiudadestoolStripButton_Click(object sender, EventArgs e)
        {
            Registros.CiudadesForm ciudad = new Registros.CiudadesForm();
            ciudad.MdiParent = this;
            ciudad.Show();
        }

        private void UsuariostoolStripButton_Click(object sender, EventArgs e)
        {
            Registros.UsuariosForm usuario = new Registros.UsuariosForm();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void VacunastoolStripButton_Click(object sender, EventArgs e)
        {
            Registros.VacunasForm vacuna = new Registros.VacunasForm();
            vacuna.MdiParent = this;
            vacuna.Show();
        }

        private void PacientestoolStripButton_Click(object sender, EventArgs e)
        {
            Registros.PacientesForm paciente = new Registros.PacientesForm();
            paciente.MdiParent = this;
            paciente.Show();
        }

        private void HistorialtoolStripButton_Click(object sender, EventArgs e)
        {
            Registros.HistorialForm rhist = new Registros.HistorialForm();
            rhist.MdiParent = this;
            rhist.Show();
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaVCS acerca = new AcercaVCS();
            acerca.MdiParent = this;
            acerca.Show();
        }
    }
}
