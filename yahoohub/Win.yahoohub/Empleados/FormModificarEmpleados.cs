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
    public partial class FormModificarEmpleados : Form
    {
        EmpleadosBL _empleados;
        PuestosBL _puestos;
        MetodoPagosBL _metodoPagos;

        public FormModificarEmpleados()
        {
            InitializeComponent();
            _empleados = new EmpleadosBL();
            listaEmpleadosBindingSource.DataSource = _empleados.ObtenerEmpleados();

            _puestos = new PuestosBL();
            listaPuestosBindingSource.DataSource = _puestos.ObtenerPuestos();

            _metodoPagos = new MetodoPagosBL();
            listaMetodoPagosBindingSource.DataSource = _metodoPagos.ObtenerMetodoPago();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void listaEmpleadosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
        private void Eliminar(int id)
        {
            var resultado = _empleados.EliminarEmpleado(id);

            if (resultado == true)
            {
                listaEmpleadosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea Eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);

                    Eliminar(id);
                }

            }

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

            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void FormModificarEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
