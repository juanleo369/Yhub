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
    public partial class FormOrdenes : Form
    {
        OrdenesBL _orden;
        EmpleadosBL _empleado;
        ClientesBL _cliente;
        EstadoPedidosBL _estadoPedidos;
        TipoPagosBL _tipoPago;
        ImpuestosBL _impuesto;
        ProductosBL _producto;
        public FormOrdenes()
        {
            InitializeComponent();
            _orden = new OrdenesBL();
            listaOrdenesBindingSource.DataSource = _orden.ObtenerOrdenes();

            _empleado = new EmpleadosBL();
            listaEmpleadosBindingSource.DataSource = _empleado.ObtenerEmpleados();

            _cliente = new ClientesBL();
            listaClientesBindingSource.DataSource = _cliente.ObtenerClientes();

            _estadoPedidos = new EstadoPedidosBL();
            listaEstadoPedidosBindingSource.DataSource = _estadoPedidos.ObtenerEstadoPedidos();

            _tipoPago = new TipoPagosBL();
            listaTipoPagosBindingSource.DataSource = _tipoPago.ObtenerTipoPagos();

            _impuesto = new ImpuestosBL();
            listaImpuestosBindingSource.DataSource = _impuesto.ObtenerImpuestos();

            _producto = new ProductosBL();
            listaProductosBindingSource.DataSource = _producto.ObtenerProductos();
        }

   

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //codigo para habilitar o desabilitar los bonotes en el navegador
        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }
        private void FormOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _orden.AgregarOrden();

            listaOrdenesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void listaOrdenesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaOrdenesBindingSource.EndEdit();
            var orden = (Orden)listaOrdenesBindingSource.Current;

       
            var resultado = _orden.GuardarOrden(orden);

            if (resultado.Exitoso == true)
            {
                listaOrdenesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Orden guardado exitosamente");
                //Codigo que permite inicializar el formulario con datos vacios

               
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _orden.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var orden = (Orden)listaOrdenesBindingSource.Current;

            _orden.AgregarOrdenDetalle(orden);

            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var orden = (Orden)listaOrdenesBindingSource.Current;
            var ordenDetalle = (OrdenDetalle)ordenDetalleBindingSource.Current;

            _orden.RemoverOrdenDetalle(orden, ordenDetalle);

            DeshabilitarHabilitarBotones(false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ordenDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void ordenDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(impuestoIdComboBox.Text == "")
            {
                MessageBox.Show("Ingrese el impuesto sobre la venta");

            }

            else
            {
                double impuesto = Convert.ToDouble(impuestoIdComboBox.Text);
                double descuento = Convert.ToDouble(descuentoTextBox.Text);

                var orden = (Orden)listaOrdenesBindingSource.Current;
                _orden.CalcularOrden(orden, impuesto, descuento);

                listaOrdenesBindingSource.ResetBindings(false);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double impuesto = Convert.ToDouble(impuestoIdComboBox.Text);
            double descuento = Convert.ToDouble(descuentoTextBox.Text);
            double abono = Convert.ToDouble(abonoTextBox.Text);
            double saldopendiente = Convert.ToDouble(saldo_PendienteTextBox.Text);
            double tipoPago = Convert.ToDouble(tipoPagoIdComboBox.Text);

            var orden = (Orden)listaOrdenesBindingSource.Current;
            _orden.CalcularOrden2(orden, impuesto, descuento,abono, saldopendiente, tipoPago);

            listaOrdenesBindingSource.ResetBindings(false);
        }

        private void subtotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ordenDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empleadoIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = Convert.ToString(empleadoIdComboBox.Text);

            if (estado == "Cotizacion")
                {
                cotizacionCheckBox.Checked = true;
                }
            else if(estado == "Pedido")
                {
                pedidoCheckBox.Checked = true;
                }
        }

        private void Anular(int id)
        {
            var resultado = _orden.AnularOrden(id);

            if (resultado == true)
            {
                listaOrdenesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular la orden");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea anular esta orden?", "Anular", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void listaOrdenesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var orden = (Orden)listaOrdenesBindingSource.Current;

            if (orden != null && orden.Id != 0 && orden.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBox1.Text);

            if (id == 0)
            {
                _orden = new OrdenesBL();
                listaOrdenesBindingSource.DataSource = _orden.ObtenerOrdenes();
            }
            
            if (id != 0)
            {

                _orden = new OrdenesBL();

                listaOrdenesBindingSource.DataSource = _orden.ObtenerOrdenes(id);


                listaOrdenesBindingSource.ResetBindings(false);
            }
        }
    }
}
