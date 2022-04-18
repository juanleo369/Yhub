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
    public partial class FormReporteClientes : Form
    {
        public FormReporteClientes()
        {
            InitializeComponent();
            var _clientes = new ClientesBL();
            var _tipoCliente = new TipoClientesBL();
            
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _clientes.ObtenerClientes();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _tipoCliente.ObtenerTipoClientes();

    
            var reporte = new ReporteClientes();
            reporte.Database.Tables["Cliente"].SetDataSource(bindingSource1);
            reporte.Database.Tables["TipoCliente"].SetDataSource(bindingSource2);
          

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReporteClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
