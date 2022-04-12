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
    public partial class FormProveedores : Form
    {
        ProveedoresBL _proveedores;

        public FormProveedores()
        {
            InitializeComponent();
            _proveedores = new ProveedoresBL();
            listaProveedoresBindingSource.DataSource = _proveedores.ObtenerProveedores();

        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nombreTextBox.Text = "";
            rTNTextBox.Text = "";
            ciudadTextBox.Text = "";
            correoTextBox.Text = "";
            telefonoTextBox.Text = "";
            deparmentoTextBox.Text = "";
            direccionTextBox.Text = "";
            ImagenPictureBox.Image = null;
        }

        private void direccionLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var proveedor = (Proveedor)listaProveedoresBindingSource.Current;

            if (proveedor != null)
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
        //codigo para la eliminación 
        private void Eliminar(int id)
        {
            var resultado = _proveedores.EliminarProveedor(id);

            if (resultado == true)
            {
                listaProveedoresBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
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

        //codigo para agregar, usando el boton agregar del navegador  

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _proveedores.AgregarProveedor();

            listaProveedoresBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void listaProveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProveedoresBindingSource.EndEdit();
            var proveedor = (Proveedor)listaProveedoresBindingSource.Current;

            if (ImagenPictureBox.Image != null)
            {
                proveedor.Imagen = Program.imageToByteArray(ImagenPictureBox.Image);
            }
            else
            {
                proveedor.Imagen = null;
            }


            var resultado = _proveedores.GuardarProveedor(proveedor);

            if (resultado.Exitoso == true)
            {
                listaProveedoresBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Proveedor guardado exitosamente");
                //Codigo que permite inicializar el formulario con datos vacios

                idTextBox.Text = "";
                nombreTextBox.Text = "";
                rTNTextBox.Text = "";
                ciudadTextBox.Text = "";
                correoTextBox.Text = "";
                telefonoTextBox.Text = "";
                deparmentoTextBox.Text = "";
                direccionTextBox.Text = "";
                ImagenPictureBox.Image = null;
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        //Codigo que permite cancelar datos generados.

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _proveedores.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
            //Codigo que permite inicializar el formulario con datos vacios

            idTextBox.Text = "";
            nombreTextBox.Text = "";
            rTNTextBox.Text = "";
            ciudadTextBox.Text = "";
            correoTextBox.Text = "";
            telefonoTextBox.Text = "";
            deparmentoTextBox.Text = "";
            direccionTextBox.Text = "";
            ImagenPictureBox.Image = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImagenPictureBox.Image = null;

        }
    }
}
