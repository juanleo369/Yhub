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
    public partial class FormPerfil : Form
    {

        SeguridadBL _seguridadBL;
        TipoUsuariosBL _tipoUsuario;
        EmpleadosBL _empleados;
        PuestosBL _puestos;

        public FormPerfil()
        {
            InitializeComponent();
            _seguridadBL = new SeguridadBL();

            listaSeguridadBindingSource.DataSource = _seguridadBL.ObtenerUsuario();



            int empleado = Program.usuario.EmpleadoId;

            _empleados = new EmpleadosBL();

            listaEmpleadosBindingSource.DataSource = _empleados.ObtenerEmpleados(empleado);
        

            _tipoUsuario = new TipoUsuariosBL();

            listaTipoUsuariosBindingSource.DataSource = _tipoUsuario.ObtenerTipoUsuarios();

            _puestos = new PuestosBL();

            listaPuestosBindingSource.DataSource = _puestos.ObtenerPuestos();
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void puestoIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
