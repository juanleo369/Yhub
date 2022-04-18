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
    public partial class FormCompras : Form
    {
        ComprasBL _compra;
        EmpleadosBL _empleado;
        ProveedoresBL _proveedor;
        ImpuestosBL _impuesto;
        MaterialesBL _material;

        public FormCompras()
        {
            InitializeComponent();
            _compra = new ComprasBL();
            listaComprasBindingSource.DataSource = _compra.ObtenerCompras();

            _empleado = new EmpleadosBL();
            listaEmpleadosBindingSource.DataSource = _empleado.ObtenerEmpleados();

            _impuesto = new ImpuestosBL();
            listaImpuestosBindingSource.DataSource = _impuesto.ObtenerImpuestos();

            _proveedor = new ProveedoresBL();
            listaProveedoresBindingSource.DataSource = _proveedor.ObtenerProveedores();

            _material = new MaterialesBL();
            listaMaterialesBindingSource.DataSource = _material.ObtenerMateriales();

        }


        private void FormCompras_Load(object sender, EventArgs e)
        {

        }

        private void descuentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _compra.AgregarCompra();

            listaComprasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void Anular(int id)
        {
            var resultado = _compra.AnularCompra(id);

            if (resultado == true)
            {
                listaComprasBindingSource.ResetBindings(false);
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

        private void listaComprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaComprasBindingSource.EndEdit();
            var compra = (Compra)listaComprasBindingSource.Current;


            var resultado = _compra.GuardarCompra(compra);

            if (resultado.Exitoso == true)
            {
                listaComprasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Compra guardada exitosamente");
                //Codigo que permite inicializar el formulario con datos vacios


            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {

            _compra.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double impuesto = Convert.ToDouble(impuestoIdComboBox.Text);
            double descuento = Convert.ToDouble(descuentoTextBox.Text);
           

            var compra = (Compra)listaComprasBindingSource.Current;
            _compra.CalcularCompra2(compra, impuesto, descuento);

            listaComprasBindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var compra = (Compra)listaComprasBindingSource.Current;
            var compraDetalle = (CompraDetalle)compraDetalleBindingSource.Current;

            _compra.RemoverCompraDetalle(compra, compraDetalle);

            DeshabilitarHabilitarBotones(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var compra = (Compra)listaComprasBindingSource.Current;

            _compra.AgregarCompraDetalle(compra);

            DeshabilitarHabilitarBotones(false);
        }

        private void compraDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;

        }

        private void compraDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (impuestoIdComboBox.Text == "")
            {
                MessageBox.Show("Ingrese el impuesto sobre la venta");

            }

            else
            {
                double impuesto = Convert.ToDouble(impuestoIdComboBox.Text);
                double descuento = Convert.ToDouble(descuentoTextBox.Text);

                var compra = (Compra)listaComprasBindingSource.Current;
                _compra.CalcularCompra(compra, impuesto, descuento);

                listaComprasBindingSource.ResetBindings(false);
            }
        }

        private void compraDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
