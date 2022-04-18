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
    public partial class FormUsuarios : Form
    {
        SeguridadBL _seguridadBL;
        TipoUsuariosBL  _tipoUsuario;
        EmpleadosBL  _empleados;
        public FormUsuarios()
        {
            InitializeComponent();
            _seguridadBL = new SeguridadBL();

            listaSeguridadBindingSource.DataSource = _seguridadBL.ObtenerUsuario();

            _empleados = new EmpleadosBL();

            listaEmpleadosBindingSource.DataSource = _empleados.ObtenerEmpleados();

            _tipoUsuario = new TipoUsuariosBL();

            listaTipoUsuariosBindingSource.DataSource = _tipoUsuario.ObtenerTipoUsuarios();
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
        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void Eliminar(int id)
        {
            var resultado = _seguridadBL.EliminarUsuario(id);

            if (resultado == true)
            {
                listaSeguridadBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el usuario");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _seguridadBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void listaSeguridadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaSeguridadBindingSource.EndEdit();
            var usuario = (Usuario)listaSeguridadBindingSource.Current;

            var resultado = _seguridadBL.GuardarUsuario(usuario);

            if (resultado.Exitoso == true)
            {
                listaSeguridadBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }
    }
}
