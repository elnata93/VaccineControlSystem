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
    public partial class ConsultaCiudadesForm : Form
    {
        public ConsultaCiudadesForm()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Ciudades ciudad = new Ciudades();
            string filtro = "1=1";

            if (FiltrotextBox.Text.Length > 0)
            {
                filtro = CamposcomboBox.Text + " like '%" + FiltrotextBox.Text + "%'";
            }

            ConsultadataGridView.DataSource = ciudad.Listado("CiudadId,Descripcion", filtro, "");

            ConteotextBox.Text = ConsultadataGridView.RowCount.ToString();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            Report.VaccineReportViewer viewer = new Report.VaccineReportViewer();
            DataTable dt = new DataTable();

            dt = (DataTable)ConsultadataGridView.DataSource;
            dt.TableName = "Ciudades";

            viewer.reporte = "CiudadesReport.rdlc";
            viewer.data = dt;

            viewer.ShowDialog();
        }
    }
}
