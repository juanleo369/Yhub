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
    public partial class FormSalida : Form
    {
        InventariosBL _inventarios;
        EmpleadosBL _empleados;
        MaterialesBL _materiales;

        public FormSalida()
        {
            InitializeComponent();
            _inventarios = new InventariosBL();
            listaInventariosBindingSource.DataSource = _inventarios.ObtenerInventarios();

            _empleados = new EmpleadosBL();
            listaEmpleadosBindingSource.DataSource = _empleados.ObtenerEmpleados();

            _materiales = new MaterialesBL();
            listaMaterialesBindingSource.DataSource = _materiales.ObtenerMateriales();

        }

        private void FormSalida_Load(object sender, EventArgs e)
        {
            //Codigo que permite inicializar el formulario con datos vacios

            //idTextBox.Text = "";
            //idTextBox2.Text = "";
            //cantidadTextBox.Text = "";
            //nombreTextBox1.Text = "";
            //descripcionTextBox.Text = "";
            //precioUnitTextBox.Text = "";
            //stockTextBox.Text = "";
            //empleadoIdComboBox.Text = null;
            //materialIdComboBox.Text = null;
            //empleadoIdComboBox.Enabled = false;
            //materialIdComboBox.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _inventarios.CancelarCambios();
            _materiales.CancelarCambios();
            _empleados.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
            //Codigo que permite inicializar el formulario con datos vacios

            //idTextBox.Text = "";
            //idTextBox2.Text = "";
            //cantidadTextBox.Text = "";
            //nombreTextBox1.Text = "";
            //descripcionTextBox.Text = "";
            //precioUnitTextBox.Text = "";
            //stockTextBox.Text = "";
            //empleadoIdComboBox.Text = null;
            //materialIdComboBox.Text = null;
            //empleadoIdComboBox.Enabled = false;
            //materialIdComboBox.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //empleadoIdComboBox.Enabled = true;
            //materialIdComboBox.Enabled = true;

            _inventarios.AgregarInventario();

            listaInventariosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void listaMaterialesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaInventariosBindingSource.EndEdit();
            listaMaterialesBindingSource.EndEdit();
            listaEmpleadosBindingSource.EndEdit();

            var inventario = (Inventario)listaInventariosBindingSource.Current;


            var resultado = _inventarios.GuardarInventario(inventario);

            if (resultado.Exitoso == true)
            {
                listaInventariosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Salida guardada exitosamente");
                //Codigo que permite inicializar el formulario con datos vacios
               
                //idTextBox.Text = "";
                //idTextBox2.Text = "";
                //cantidadTextBox.Text = "";
                //nombreTextBox1.Text = "";
                //descripcionTextBox.Text = "";
                //precioUnitTextBox.Text = "";
                //stockTextBox.Text = "";
                //empleadoIdComboBox.Text = null;
                //materialIdComboBox.Text = null;
                //empleadoIdComboBox.Enabled = false;
                //materialIdComboBox.Enabled = false;

            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int cantidad = 0;
            //int stock = 0;
            //int actualizacion = 0;

            //cantidad = Convert.ToInt32(cantidadTextBox.Text);
            //stock = Convert.ToInt32(stockTextBox.Text);

            // actualizacion = stock-cantidad;

            //stockTextBox.Text = Convert.ToString(actualizacion);

        }

        private void listaMaterialesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaInventariosBindingSource.EndEdit();
            listaMaterialesBindingSource.EndEdit();
            listaEmpleadosBindingSource.EndEdit();

            var materiales = (Material)listaMaterialesBindingSource.Current;


            var resultado = _materiales.GuardarMaterial(materiales);


            if (resultado.Exitoso == true)
            {
                listaMaterialesBindingSource.ResetBindings(true);
                DeshabilitarHabilitarBotones(false);
                MessageBox.Show("Actualización de Materiales guardada exitosamente");
              
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var inventario = (Inventario)listaInventariosBindingSource.Current;

            _inventarios.AgregarInventarioDetalle(inventario);

            DeshabilitarHabilitarBotones(false);
        }

        private void inventarioDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;

        }

        private void inventarioDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (empleadoIdComboBox.Text == "")
            {
                MessageBox.Show("Ingrese un empleado");

            }

            else
            {
                 var inventario = (Inventario)listaInventariosBindingSource.Current;
                _inventarios.CalcularInventarios(inventario);

                listaInventariosBindingSource.ResetBindings(false);
            }
        }
    }
}
