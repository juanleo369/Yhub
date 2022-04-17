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
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();
            var _producto = new ProductosBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _producto.ObtenerProductos();

            var reporte = new ReporteProductos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }

        private void FormReporteProductos_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
