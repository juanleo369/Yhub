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
    public partial class FormProductos : Form
    {
        //Variables locales 
        ProductosBL _productos;
        CategoriasBL _categorias;
        PrecioCuadradosBL _preciocuadrado; 

        //Inicializador de las tablas e intancias de sus listas. 
        public FormProductos()
        {
            InitializeComponent();
            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();

            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _preciocuadrado = new PrecioCuadradosBL();
            listaPrecioCuadradosBindingSource.DataSource = _preciocuadrado.ObtenerPrecioCuadrados();

        }

    

        private void FormProductos_Load(object sender, EventArgs e)
        {
            //Codigo que permite inicializar el formulario con datos vacios
            nombreTextBox.Text = "";
            precioTextBox.Text = "";
            tamaño_AnchoTextBox.Text = "";
            tamaño_LargoTextBox.Text = "";
            descripcionTextBox.Text = "";
            ImagenPictureBox.Image = null;
            categoriaIdComboBox.Text = null;
            precioCuadradoIdComboBox.Text = null;
        }
        

       //codigo para habilitar o desabilitar los bonotes en el navegador
            private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor ;
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

   
        private void listaProductosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
        //codigo para agregar, usando el boton agregar del navegador  

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            _productos.AgregarProducto();

            listaProductosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        //codigo para eliminar, usando el boton delete del navegador  

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
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
        //codigo para Guardar, usando el boton save del navegador  

        private void listaProductosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
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
                //Codigo que permite inicializar el formulario con datos vacios
                nombreTextBox.Text = "";
                precioTextBox.Text = "";
                tamaño_AnchoTextBox.Text = "";
                tamaño_LargoTextBox.Text = "";
                descripcionTextBox.Text = "";
                ImagenPictureBox.Image = null;
                categoriaIdComboBox.Text = null;
                precioCuadradoIdComboBox.Text = null;
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }


        }

        //codigo para Cancelar, usando el boton del navegador  

        private void toolStripButtonCancelar_Click_1(object sender, EventArgs e)
        {
            _productos.CancelarCambios();
            DeshabilitarHabilitarBotones(true);

            //Codigo que permite inicializar el formulario con datos vacios
            nombreTextBox.Text = "";
            precioTextBox.Text = "";
            tamaño_AnchoTextBox.Text = "";
            tamaño_LargoTextBox.Text = "";
            descripcionTextBox.Text = "";
            ImagenPictureBox.Image = null;
            categoriaIdComboBox.Text = null;
            precioCuadradoIdComboBox.Text = null;

        }

        //codigo para crear un cuadro de dialogo y elegir una imagen, usando un Boton  

        private void button1_Click_1(object sender, EventArgs e)
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
        //codigo para cancelar una imagen seleccionada, usando un Boton  

        private void button2_Click_1(object sender, EventArgs e)
        {
            ImagenPictureBox.Image = null;

        }
        // codigo para cerrar el form con un boton x

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }
        //Botón que realiza los calculos de los precios de los productos
        private void button3_Click(object sender, EventArgs e)
        {
             int preciomedida = 0;
            int tamanol = 0;
            int tamanoa = 0;
            int tamanototal = 0;
            double preciototal= 0;




            preciomedida = Convert.ToInt32(precioCuadradoIdComboBox.Text);
            tamanoa = Convert.ToInt32(tamaño_AnchoTextBox.Text);
            tamanol = Convert.ToInt32(tamaño_LargoTextBox.Text);

            tamanototal = tamanoa * tamanol;
            preciototal = tamanototal * preciomedida;

            precioTextBox.Text = Convert.ToString(preciototal);


        }

        private void ImagenPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
