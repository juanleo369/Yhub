using BL.yahoohub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.yahoohub
{
    public partial class FormReporteProveedores : Form
    {
        public FormReporteProveedores()
        {
            InitializeComponent();
            var _proveedor = new ProveedoresBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _proveedor.ObtenerProveedores();

            var reporte = new ReporteProveedores();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReporteProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
