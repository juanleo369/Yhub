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
    public partial class FormInventarios : Form
    {
        MaterialesBL _materiales;
        public FormInventarios()
        {
            InitializeComponent();
            _materiales = new MaterialesBL();
            listaMaterialesBindingSource.DataSource = _materiales.ObtenerMateriales();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInventarios_Load(object sender, EventArgs e)
        {

        }
    }
}
