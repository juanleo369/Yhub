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
    public partial class FormPlanillas : Form
    {
        PlanillasBL _planillas;
        EmpleadosBL _empleados;
        public FormPlanillas()
        {
            InitializeComponent();
            _empleados = new EmpleadosBL();
            listaEmpleadosBindingSource.DataSource = _empleados.ObtenerEmpleados();

            _planillas = new PlanillasBL();
            listaPlanillasBindingSource.DataSource = _planillas.ObtenerPlanillas();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
            _planillas.AgregarPlanilla();

            listaPlanillasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //codigo para la eliminación 
        private void Eliminar(int id)
        {
            var resultado = _planillas.EliminarPlanilla(id);

            if (resultado == true)
            {
                listaPlanillasBindingSource.ResetBindings(false);
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

        private void listaPlanillasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaPlanillasBindingSource.EndEdit();
            var planilla = (Planilla)listaPlanillasBindingSource.Current;



            var resultado = _planillas.GuardarPlanilla(planilla);

            if (resultado.Exitoso == true)
            {
                listaPlanillasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Planilla guardada exitosamente");


            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _planillas.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void listaPlanillasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
