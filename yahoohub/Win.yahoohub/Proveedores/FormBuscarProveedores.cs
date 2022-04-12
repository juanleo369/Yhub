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
    public partial class FormBuscarProveedores : Form
    {
        ProveedoresBL _proveedores;

        public FormBuscarProveedores()
        {
            InitializeComponent();
            _proveedores = new ProveedoresBL();
            listaProveedoresBindingSource.DataSource = _proveedores.ObtenerProveedores();

        }


        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
