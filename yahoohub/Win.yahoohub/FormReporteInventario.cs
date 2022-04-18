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
    public partial class FormReporteInventario : Form
    {
        public FormReporteInventario()
        {
            InitializeComponent();
            var _inventario = new MaterialesBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _inventario.ObtenerMateriales();

            var reporte = new ReporteInventarios();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReporteInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
