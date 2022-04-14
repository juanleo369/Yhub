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
    public partial class FormBuscarSalidas : Form
    {
        InventariosBL _inventarios;
        public FormBuscarSalidas()
        {
            InitializeComponent();
            _inventarios = new InventariosBL();
            listaInventariosBindingSource.DataSource = _inventarios.ObtenerInventarios();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscarSalidas_Load(object sender, EventArgs e)
        {

        }
    }
}
