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
    public partial class FormBuscarOrdenes : Form
    {
        OrdenesBL _orden;
        public FormBuscarOrdenes()
        {
            InitializeComponent();
            _orden = new OrdenesBL();
            listaOrdenesBindingSource.DataSource = _orden.ObtenerOrdenes();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscarOrdenes_Load(object sender, EventArgs e)
        {

        }
    }
}
