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
    public partial class FormBuscarCompras : Form
    {
        ComprasBL  _compras;

        public FormBuscarCompras()
        {
            InitializeComponent();
            _compras = new ComprasBL();
            listaComprasBindingSource.DataSource = _compras.ObtenerCompras();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscarCompras_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void compraDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
