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
    public partial class FormReporteOrdenes : Form
    {

        public FormReporteOrdenes()
        {
            InitializeComponent();

            var _orden = new OrdenesBL();
            var _empleado = new EmpleadosBL();
            var _cliente = new ClientesBL();
            var _estadoPedidos = new EstadoPedidosBL();
            var _tipoPago = new TipoPagosBL();
            var _impuesto = new ImpuestosBL();
            var _producto = new ProductosBL();
            var _categoria = new CategoriasBL();


            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _orden.ObtenerOrdenes();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _empleado.ObtenerEmpleados();

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _cliente.ObtenerClientes();

            var bindingSource4 = new BindingSource();
            bindingSource4.DataSource = _estadoPedidos.ObtenerEstadoPedidos();

            var bindingSource5 = new BindingSource();
            bindingSource5.DataSource = _tipoPago.ObtenerTipoPagos();

            var bindingSource6 = new BindingSource();
            bindingSource6.DataSource = _impuesto.ObtenerImpuestos();

            var bindingSource7 = new BindingSource();
            bindingSource7.DataSource = _producto.ObtenerProductos();

            var bindingSource8 = new BindingSource();
            bindingSource8.DataSource = _categoria.ObtenerCategorias();

            var reporte = new ReporteOrdenes();
            reporte.Database.Tables["Orden"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Empleado"].SetDataSource(bindingSource2);
            reporte.Database.Tables["Cliente"].SetDataSource(bindingSource3);
            reporte.Database.Tables["EstadoPedido"].SetDataSource(bindingSource4);
            reporte.Database.Tables["TipoPago"].SetDataSource(bindingSource5);
            reporte.Database.Tables["Impuesto"].SetDataSource(bindingSource6);
            reporte.Database.Tables["Producto"].SetDataSource(bindingSource7);
            reporte.Database.Tables["Categoria"].SetDataSource(bindingSource8);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void FormReporteOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
