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
    public partial class FormBuscarProductos : Form
    {
        ProductosBL _productos;
      //  CategoriasBL _categorias;
        //PrecioCuadradosBL _preciocuadrado;

        public FormBuscarProductos()
        {
            InitializeComponent();
             _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();
/*
            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _preciocuadrado = new PrecioCuadradosBL();
            listaPrecioCuadradosBindingSource.DataSource = _preciocuadrado.ObtenerPrecioCuadrados();*/

        }

    

        private void FormBuscarProductos_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
