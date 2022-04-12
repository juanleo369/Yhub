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
    public partial class FormClientes : Form
    {
        ClientesBL _clientes;
        TipoClientesBL _tipoClientes;
        public FormClientes()
        {
            InitializeComponent();
            _clientes = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientes.ObtenerClientes();

            _tipoClientes = new TipoClientesBL();
            listaTipoClientesBindingSource.DataSource = _tipoClientes.ObtenerTipoClientes();
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
     
        //codigo para la eliminación 
        private void Eliminar(int id)
        {
            var resultado = _clientes.EliminarCliente(id);

            if (resultado == true)
            {
                listaClientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }
        private void imagenLabel_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)listaClientesBindingSource.Current;

            if (cliente != null)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
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
            tipoClienteIdComboBox.Text = null;
        }
        
        //codigo para agregar, usando el boton agregar del navegador  
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();

            listaClientesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }
        
        //codigo para eliminar, usando el boton delete del navegador  
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

        //codigo para Guardar, usando el boton save del navegador  
        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente)listaClientesBindingSource.Current;

            if (ImagenPictureBox.Image != null)
            {
                cliente.Imagen = Program.imageToByteArray(ImagenPictureBox.Image);
            }
            else
            {
                cliente.Imagen = null;
            }


            var resultado = _clientes.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cliente guardado exitosamente");
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
                tipoClienteIdComboBox.Text = null;
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _clientes.CancelarCambios();
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
            tipoClienteIdComboBox.Text = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
