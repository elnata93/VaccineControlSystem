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
    public partial class ConsultaUsuariosForm : Form
    {
        public ConsultaUsuariosForm()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios  user = new Usuarios();
            string filtro = "1=1";

            if (FiltrotextBox.Text.Length > 0)
            {
                filtro = CamposcomboBox.Text + " like '%" + FiltrotextBox.Text + "%'";
            }

            ConsultadataGridView.DataSource = user.Listado("UsuarioId,NombresUsuarios,Nombres,Apellidos,Direccion,Telefono,Email,Contrasena,TipoUsuarioId,CiudadId,Fecha,Imagen", filtro, "");

            ConteotextBox.Text = ConsultadataGridView.RowCount.ToString();
        }
        //private int UsuarioId = 0;
        //private string Descripcion = "";
        private void FiltrotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          //if(CamposcomboBox.Text == this.Descripcion )
          //{
          //    if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
          //        e.Handled = false;
          //    else
          //        e.Handled = true;
          //}
          //else
          //{
          //    if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
          //        e.Handled = false;
          //    else
          //        e.Handled = true;
          //}
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            Report.VaccineReportViewer viewer =  new Report.VaccineReportViewer();
            DataTable dt = new DataTable();

            dt = (DataTable)ConsultadataGridView.DataSource;
            dt.TableName = "Usuarios";

            viewer.reporte = "UsuariosReport.rdlc";
            viewer.data = dt;

            viewer.ShowDialog();
        }
    }
}
