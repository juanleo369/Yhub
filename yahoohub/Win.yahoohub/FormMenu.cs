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
    public partial class FormMenu : Form
    {
       EmpleadosBL  _empleado;

        public FormMenu()
        {
            InitializeComponent();
            customizeDesign();
            panelUsuario.Width = 0;

            int empleado = Program.usuario.EmpleadoId;

            _empleado = new EmpleadosBL();

            listaEmpleadosBindingSource.DataSource = _empleado.ObtenerEmpleados(empleado);
        }
        private void customizeDesign()
        {
            //Codigo para Volver los paneles de Submenus no visibles.
            panelOrdenesSubmenu.Visible = false;
            panelComprasSubmenu.Visible = false;
            panelEmpleadosSubmenu.Visible = false;
            panelInventariosSubmenu.Visible = false;
            panelProductosSubmenu.Visible = false;
            panelClientesSubmenu.Visible = false;
            panelProveedoresSubmenu.Visible = false;
            panelReportesSubmenu.Visible = false;

        }
        //Codigo para ocultar submenus que esten visibles
        private void hideSubMenu()
        {
            if (panelOrdenesSubmenu.Visible == true)
                panelOrdenesSubmenu.Visible = false;
            if (panelComprasSubmenu.Visible == true)
                panelComprasSubmenu.Visible = false;
            if (panelEmpleadosSubmenu.Visible == true)
                panelEmpleadosSubmenu.Visible = false;
            if (panelInventariosSubmenu.Visible == true)
                panelInventariosSubmenu.Visible = false;
            if (panelProductosSubmenu.Visible == true)
                panelProductosSubmenu.Visible = false;
            if (panelClientesSubmenu.Visible == true)
                panelClientesSubmenu.Visible = false;
            if (panelProveedoresSubmenu.Visible == true)
                panelProveedoresSubmenu.Visible = false;
            if (panelReportesSubmenu.Visible == true)
                panelReportesSubmenu.Visible = false;

        }

        // Codigo que permite mostrar los submenus
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {

            if (Program.usuario != null)
            {
                //label1.Text = Program.usuario.Empleado.Nombre + " " + Program.usuario.EmpleadoId;
                label2.Text = Program.usuario.TipoUsuario.Descripcion;

             /*
                if (Program.usuario.Empleado.Imagen != null)
                {
                    MemoryStream ms = new MemoryStream(Program.usuario.Empleado.Imagen);
                    System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);

                    pictureBox3.Image = Image.FromStream(ms);
                }
             */
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // variable proiavda para almacenar si existe un form hijo abierto
        private Form activeForm = null;


        //codigo que sirve para abrir Formularios hijos en el panel central
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        #region Ordenes
        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOrdenesSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOrdenes());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBuscarOrdenes());
            hideSubMenu();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }
        #endregion

        #region Compras
        private void btnCompras_Click(object sender, EventArgs e)
        {
            showSubMenu(panelComprasSubmenu);

        }


        private void button7_Click(object sender, EventArgs e)
        {
          // Codigo que sirve para llamar al form hijo
            openChildForm(new FormCompras());

            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Codigo que sirve para llamar al form hijo
            openChildForm(new FormBuscarCompras());

            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }
        #endregion

        #region Empleados
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpleadosSubmenu);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormPuestos());

            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormBuscarEmpleados());

            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModificarEmpleados());

            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormEmpleados());

            hideSubMenu();
        }
        #endregion

        #region inventario
        private void btnInventarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInventariosSubmenu);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormSalida());

            hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormMateriales());

            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormBuscarSalidas());

            hideSubMenu();
        }
        #endregion

        #region Productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProductosSubmenu);

        }


        private void button25_Click(object sender, EventArgs e)
        {
           //Codigo que sirve para llamar al form hijo
            openChildForm(new FormProductos());

            hideSubMenu();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo

            openChildForm(new FormCategorias());

            hideSubMenu();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo

            openChildForm(new FormPrecioCuadrados()); 
            hideSubMenu();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormBuscarProductos()); 
            hideSubMenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormModificarProductos());
            hideSubMenu();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }
        #endregion

        #region Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientesSubmenu);

        }


        private void button29_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormClientes());
            hideSubMenu();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
       
            openChildForm(new FormBuscarClientes());
            hideSubMenu();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormModificarClientes());
            hideSubMenu();
        }
        #endregion

        #region Proveedores
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProveedoresSubmenu);

        }

        private void button31_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormProveedores());
            hideSubMenu();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //Codigo que sirve para llamar al form hijo
            openChildForm(new FormBuscarProveedores());
            hideSubMenu();
        }
        private void button26_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModificarProveedores());
            hideSubMenu();
        }
        #endregion

       #region Reportes
        private void button32_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportesSubmenu);

        }



        private void button39_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteOrdenes());
            hideSubMenu();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteEmpleados());
            hideSubMenu();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteInventario());
            hideSubMenu();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteProductos());
            hideSubMenu();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteClientes());
            hideSubMenu();

        }

        private void button33_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReporteProveedores());
            hideSubMenu();
        }

        #endregion

        private void panelProductosSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInventariosSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void panelStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("h:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();

        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea salir del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                this.Hide();
                formLogin.ShowDialog();
                this.Close();
            }

            if (result == DialogResult.No)
            {

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //poner codigo para llamar form hijo

            hideSubMenu();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormPlanillas());
            hideSubMenu();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormInventarios());
            hideSubMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Cerrar Sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                this.Hide();
                formLogin.ShowDialog();
                this.Close();
            }

            if (result == DialogResult.No)
            {

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (panelUsuario.Width == 0)
            {
                panelUsuario.Width = 313;
            }
            else
                panelUsuario.Width = 0;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panelReportesSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormPerfil());
            hideSubMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormUsuarios());
            hideSubMenu();
        }
    }
}


