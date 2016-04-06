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

namespace VaccineControlSystem.Consultas
{
    public partial class ConsultaVacunasForm : Form
    {
        public ConsultaVacunasForm()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Vacunas vacuna = new Vacunas();
            string filtro = "1=1";

            if (FiltrotextBox.Text.Length > 0)
            {
                filtro = CamposcomboBox.Text + " like '%" + FiltrotextBox.Text + "%'";
            }

            ConsultadataGridView.DataSource = vacuna.Listado("VacunaId,NombresVacunas", filtro, "");

            ConteotextBox.Text = ConsultadataGridView.RowCount.ToString();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            Report.VaccineReportViewer viewer = new Report.VaccineReportViewer();
            DataTable dt = new DataTable();

            dt = (DataTable)ConsultadataGridView.DataSource;
            dt.TableName = "Vacunas";

            viewer.reporte = "VacunasReport.rdlc";
            viewer.data = dt;

            viewer.ShowDialog();
        }

        private void ConsultaVacunasForm_Load(object sender, EventArgs e)
        {

        }

        private void FiltrotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
