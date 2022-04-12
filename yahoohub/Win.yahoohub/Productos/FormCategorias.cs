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
    public partial class FormCategorias : Form
    {
        //Variables locales 

        CategoriasBL _categorias;

        //Inicializador de las tablas e intancias de sus listas. 

        public FormCategorias()
        {
            InitializeComponent();
            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {

        }
        //codigo para la eliminación 
        private void Eliminar(int id)
        {
            var resultado = _categorias.EliminarCategoria(id);

            if (resultado == true)
            {
                listaCategoriasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la Categoria");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _categorias.AgregarCategoria();

            listaCategoriasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
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
        //codigo para Guardar, usando el boton save del navegador  

        private void listaCategoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaCategoriasBindingSource.EndEdit();
            var categoria = (Categoria)listaCategoriasBindingSource.Current;

    

            var resultado = _categorias.GuardarCategoria(categoria);

            if (resultado.Exitoso == true)
            {
                listaCategoriasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Categoria guardada exitosamente");
               
            
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _categorias.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void listaCategoriasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
