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
    public partial class FormMateriales : Form
    {
        MaterialesBL _materiales;

        public FormMateriales()
        {
            InitializeComponent();
            _materiales = new MaterialesBL();
            listaMaterialesBindingSource.DataSource = _materiales.ObtenerMateriales();
        }

        private void FormMateriales_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void listaMaterialesBindingNavigator_RefreshItems(object sender, EventArgs e)
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
            _materiales.AgregarMaterial();

            listaMaterialesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        //codigo para la eliminación 
        private void Eliminar(int id)
        {
            var resultado = _materiales.EliminarMaterial(id);

            if (resultado == true)
            {
                listaMaterialesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la Categoria");
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

        private void listaMaterialesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaMaterialesBindingSource.EndEdit();
            var materiales = (Material)listaMaterialesBindingSource.Current;



            var resultado = _materiales.GuardarMaterial(materiales);

            if (resultado.Exitoso == true)
            {
                listaMaterialesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Material guardado exitosamente");


            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _materiales.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }
    }
}
