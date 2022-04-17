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
            
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _orden.ObtenerOrdenes();

            var bindingSource1 = new BindingSource();
            bindingSource.DataSource = _empleado.ObtenerEmpleados();

            var bindingSource2 = new BindingSource();
            bindingSource.DataSource = _cliente.ObtenerClientes();

            var bindingSource3 = new BindingSource();
            bindingSource.DataSource = _estadoPedidos.ObtenerEstadoPedidos();

            var bindingSource4 = new BindingSource();
            bindingSource.DataSource = _tipoPago.ObtenerTipoPagos();

            var bindingSource5 = new BindingSource();
            bindingSource.DataSource = _impuesto.ObtenerImpuestos();

            var bindingSource6 = new BindingSource();
            bindingSource.DataSource = _producto.ObtenerProductos();



            var reporte = new ReporteOrdenes();
            // reporte.SetDataSource(bindingSource);
            reporte.Database.Tables["Orden"].SetDataSource(bindingSource);
            reporte.Database.Tables["OrdenDetalle"].SetDataSource(bindingSource);
            reporte.Database.Tables["Empleado"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Cliente"].SetDataSource(bindingSource2);
            reporte.Database.Tables["EstadoPedido"].SetDataSource(bindingSource3);
            reporte.Database.Tables["TipoPago"].SetDataSource(bindingSource4);
            reporte.Database.Tables["Impuesto"].SetDataSource(bindingSource5);
            reporte.Database.Tables["Producto"].SetDataSource(bindingSource6);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void FormReporteOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);

            var _orden = new OrdenesBL();
            var _empleado = new EmpleadosBL();
            var _cliente = new ClientesBL();
            var _estadoPedidos = new EstadoPedidosBL();
            var _tipoPago = new TipoPagosBL();
            var _impuesto = new ImpuestosBL();
            var _producto = new ProductosBL();



            var bindingSource = new BindingSource();
            bindingSource.DataSource = _orden.ObtenerOrdenes(id);

            var bindingSource1 = new BindingSource();
            bindingSource.DataSource = _empleado.ObtenerEmpleados();

            var bindingSource2 = new BindingSource();
            bindingSource.DataSource = _cliente.ObtenerClientes();

            var bindingSource3 = new BindingSource();
            bindingSource.DataSource = _estadoPedidos.ObtenerEstadoPedidos();

            var bindingSource4 = new BindingSource();
            bindingSource.DataSource = _tipoPago.ObtenerTipoPagos();

            var bindingSource5 = new BindingSource();
            bindingSource.DataSource = _impuesto.ObtenerImpuestos();

            var bindingSource6 = new BindingSource();
            bindingSource.DataSource = _producto.ObtenerProductos();



            var reporte = new ReporteOrdenes();
            // reporte.SetDataSource(bindingSource);
            reporte.Database.Tables["Orden"].SetDataSource(bindingSource);
            reporte.Database.Tables["OrdenDetalle"].SetDataSource(bindingSource);
            reporte.Database.Tables["Empleado"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Cliente"].SetDataSource(bindingSource2);
            reporte.Database.Tables["EstadoPedido"].SetDataSource(bindingSource3);
            reporte.Database.Tables["TipoPago"].SetDataSource(bindingSource4);
            reporte.Database.Tables["Impuesto"].SetDataSource(bindingSource5);
            reporte.Database.Tables["Producto"].SetDataSource(bindingSource6);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
