using BL.yahoohub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.yahoohub
{
    public partial class FormEmpleados : Form
    {
        EmpleadosBL _empleados;
        PuestosBL _puestos;
        MetodoPagosBL _metodoPagos;

        public FormEmpleados()
        {
            InitializeComponent();
            _empleados = new EmpleadosBL();
            listaEmpleadosBindingSource.DataSource = _empleados.ObtenerEmpleados();

            _puestos = new PuestosBL();
            listaPuestosBindingSource.DataSource = _puestos.ObtenerPuestos();

            _metodoPagos = new MetodoPagosBL();
            listaMetodoPagosBindingSource.DataSource = _metodoPagos.ObtenerMetodoPago();

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void apellidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var empleado = (Empleado)listaEmpleadosBindingSource.Current;

            if (empleado != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var filestream = fileInfo.OpenRead();

                    ImagenPictureBox.Image = Image.FromStream(filestream);
                }
            }
            else
            {
                MessageBox.Show("Cree un Cliente antes de asignarle una imagen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImagenPictureBox.Image = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _empleados.AgregarEmpleado();

            listaEmpleadosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void listaEmpleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaEmpleadosBindingSource.EndEdit();
            var empleado = (Empleado)listaEmpleadosBindingSource.Current;

            if (ImagenPictureBox.Image != null)
            {
                empleado.Imagen = Program.imageToByteArray(ImagenPictureBox.Image);
            }
            else
            {
                empleado.Imagen = null;
            }


            var resultado = _empleados.GuardarEmpleado(empleado);

            if (resultado.Exitoso == true)
            {
                listaEmpleadosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Empleado guardado exitosamente");
                //Codigo que permite inicializar el formulario con datos vacios
                salarioTextBox.Text = "";
                idTextBox.Text = "";
                nombreTextBox.Text = "";
                apellidoTextBox.Text = "";
                rTNTextBox.Text = "";
                ciudadTextBox.Text = "";
                correoTextBox.Text = "";
                telefonoTextBox.Text = "";
                deparmentoTextBox.Text = "";
                direccionTextBox.Text = "";
                ImagenPictureBox.Image = null;
                metodoIdComboBox.Text = null;
                puestoIdComboBox.Text = null;
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            //Codigo que permite inicializar el formulario con datos vacios

            idTextBox.Text = "";
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            rTNTextBox.Text = "";
            ciudadTextBox.Text = "";
            correoTextBox.Text = "";
            telefonoTextBox.Text = "";
            salarioTextBox.Text = "";
            deparmentoTextBox.Text = "";
            direccionTextBox.Text = "";
            ImagenPictureBox.Image = null;
            metodoIdComboBox.Text = null;
            puestoIdComboBox.Text = null;
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _empleados.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
            //Codigo que permite inicializar el formulario con datos vacios
            idTextBox.Text = "";
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            rTNTextBox.Text = "";
            ciudadTextBox.Text = "";
            correoTextBox.Text = "";
            telefonoTextBox.Text = "";
            deparmentoTextBox.Text = "";
            direccionTextBox.Text = "";
            ImagenPictureBox.Image = null;
            metodoIdComboBox.Text = null;
            puestoIdComboBox.Text = null;
            salarioTextBox.Text = "";

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
