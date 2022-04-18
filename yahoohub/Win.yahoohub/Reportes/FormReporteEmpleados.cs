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
    public partial class FormReporteEmpleados : Form
    {
        public FormReporteEmpleados()
        {
            InitializeComponent();
            var _empleados = new EmpleadosBL();
            var _puestos = new PuestosBL();
            var _metodopago = new MetodoPagosBL();


            

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _empleados.ObtenerEmpleados();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _puestos.ObtenerPuestos();

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _metodopago.ObtenerMetodoPago();



            var reporte = new ReporteEmpleados();
            reporte.Database.Tables["Empleado"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Puesto"].SetDataSource(bindingSource2);
            reporte.Database.Tables["MetodoPago"].SetDataSource(bindingSource3);
          

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReporteEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
