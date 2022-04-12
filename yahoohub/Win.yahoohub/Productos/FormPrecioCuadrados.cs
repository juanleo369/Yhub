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
    public partial class FormPrecioCuadrados : Form
    {

        PrecioCuadradosBL _preciocuadrado;

        public FormPrecioCuadrados()
        {
            InitializeComponent();
            _preciocuadrado = new PrecioCuadradosBL();
            listaPrecioCuadradosBindingSource.DataSource = _preciocuadrado.ObtenerPrecioCuadrados();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
        private void FormPrecioCuadrados_Load(object sender, EventArgs e)
        {

        }
        private void Eliminar(int id)
        {
            var resultado = _preciocuadrado.EliminarPrecioCuadrado(id);

            if (resultado == true)
            {
                listaPrecioCuadradosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la Categoria");
            }
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _preciocuadrado.AgregarPrecioCuadrado();

            listaPrecioCuadradosBindingSource.MoveLast();

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

        private void listaPrecioCuadradosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaPrecioCuadradosBindingSource.EndEdit();
            var precioCuadrado = (PrecioCuadrado)listaPrecioCuadradosBindingSource.Current;



            var resultado = _preciocuadrado.GuardarPrecioCuadrado(precioCuadrado);

            if (resultado.Exitoso == true)
            {
                listaPrecioCuadradosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Precio guardado exitosamente");


            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _preciocuadrado.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

    }
}
