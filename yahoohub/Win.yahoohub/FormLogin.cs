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
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;
      public bool UsuarioAutenticado { get; set; }
      public bool Cancelar { get; set; }

      public bool u { get; set; }
      public bool c { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            _seguridad = new SeguridadBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            button1.Enabled = false;
            button1.Text = "VERIFICANDO...";
            Application.DoEvents();


            var resultado = _seguridad.Autorizar(usuario, contrasena);

            // codigo para validar credenciales
            if(resultado != null)
            {
               c = u;
               Program.usuario = resultado;
                //codigo para abrir form menu y cerrar form login
                FormMenu formMenu = new FormMenu();
                this.Hide();
                formMenu.ShowDialog();
                this.Close();
            }
            else
            { 
            MessageBox.Show("Usuario o Contraseña incorrecto, intente de nuevo.");
            }

            button1.Enabled = true;
            button1.Text = "INGRESAR";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         UsuarioAutenticado = !Cancelar;
         c = !u;
        }

       

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                //UsuarioAutenticado = Cancelar;
                Application.Exit();
            }

            if (result == DialogResult.No)
            {

            }
        }
    }
}
