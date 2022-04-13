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
    public partial class FormPuestos : Form
    {
        PuestosBL _puestos;

        public FormPuestos()
        {
            InitializeComponent();
            _puestos = new PuestosBL();
            listaPuestosBindingSource.DataSource = _puestos.ObtenerPuestos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPuestos_Load(object sender, EventArgs e)
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _puestos.AgregarPuesto();

            listaPuestosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        //codigo para la eliminación 
        private void Eliminar(int id)
        {
            var resultado = _puestos.EliminarPuesto(id);

            if (resultado == true)
            {
                listaPuestosBindingSource.ResetBindings(false);
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

        private void listaPuestosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaPuestosBindingSource.EndEdit();
            var puesto = (Puesto)listaPuestosBindingSource.Current;



            var resultado = _puestos.GuardarPuesto(puesto);

            if (resultado.Exitoso == true)
            {
                listaPuestosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Puesto guardado exitosamente");


            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _puestos.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }
    }
}
