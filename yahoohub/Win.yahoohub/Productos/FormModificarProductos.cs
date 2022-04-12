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
    public partial class FormModificarProductos : Form
    {
        //Variables locales 
        ProductosBL _productos;
        CategoriasBL _categorias;
        PrecioCuadradosBL _preciocuadrado;

        public FormModificarProductos()
        {
            InitializeComponent();
            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();

            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _preciocuadrado = new PrecioCuadradosBL();
            listaPrecioCuadradosBindingSource.DataSource = _preciocuadrado.ObtenerPrecioCuadrados();

        }

        private void Eliminar(int id)
        {
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }




        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductosBindingSource.Current;

            if (producto != null)
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
                MessageBox.Show("Cree un Producto antes de asignarle una imagen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImagenPictureBox.Image = null;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FormModificarProductos_Load(object sender, EventArgs e)
        {

        }
        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _productos.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea Eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(IdTextBox.Text);

                    Eliminar(id);
                }

            }
        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit();
            var producto = (Producto)listaProductosBindingSource.Current;

            if (ImagenPictureBox.Image != null)
            {
                producto.Imagen = Program.imageToByteArray(ImagenPictureBox.Image);
            }
            else
            {
                producto.Imagen = null;
            }


            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto guardado exitosamente");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int preciomedida = 0;
            int tamanol = 0;
            int tamanoa = 0;
            int tamanototal = 0;
            double preciototal = 0;




            preciomedida = Convert.ToInt32(precioCuadradoIdComboBox.Text);
            tamanoa = Convert.ToInt32(tamaño_AnchoTextBox.Text);
            tamanol = Convert.ToInt32(tamaño_LargoTextBox.Text);

            tamanototal = tamanoa * tamanol;
            preciototal = tamanototal * preciomedida;

            precioTextBox.Text = Convert.ToString(preciototal);


        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
