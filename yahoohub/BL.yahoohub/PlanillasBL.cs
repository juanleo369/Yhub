using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class PlanillasBL
    {
        //Variable local de la base y Variable de la lista
        Contexto _contexto;

        public BindingList<Planilla> ListaPlanillas { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public PlanillasBL()
        {
            _contexto = new Contexto();
            ListaPlanillas = new BindingList<Planilla>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Planilla> ObtenerPlanillas()
        {
            _contexto.Planillas.Load();
            ListaPlanillas = _contexto.Planillas.Local.ToBindingList();
            return ListaPlanillas;
        }

        //Codigo que sirve para Guardar datos en la base de datos
        public ResultadoPlanilla GuardarPlanilla(Planilla planilla)
        {
            var resultado = Validar(planilla);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        //Codigo que sirve para agregar datos en la base de datos
        public void AgregarPlanilla()
        {
            var nuevoPlanillas = new Planilla();
            ListaPlanillas.Add(nuevoPlanillas);
        }

        //Codigo que sirve para eliminar datos en la base de datos
        public bool EliminarPlanilla(int id)
        {
            foreach (var planilla in ListaPlanillas)
            {
                if (planilla.PlanillaId == id)
                {
                    ListaPlanillas.Remove(planilla);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoPlanilla Validar(Planilla planillas)
        {
            var resultado = new ResultadoPlanilla();
            resultado.Exitoso = true;

            if (planillas.EmpleadoId <= 0)
            {
                resultado.Mensaje = "Ingrese el empleado";
                resultado.Exitoso = false;

            }

            if (planillas.Pago <= 0)
            {
                resultado.Mensaje = "Ingrese la cantidad a pagar";
                resultado.Exitoso = false;

            }

            if (string.IsNullOrEmpty(planillas.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese descripcion del pago";
                resultado.Exitoso = false;

            }
            return resultado;
        }
    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class Planilla
    {
        public int PlanillaId { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public DateTime FechaPago { get; set; }
        public double Pago { get; set; }
        public string Descripcion { get; set; }

    }

    //Codigo que sirve para validar los campos que se ingresan

    public class ResultadoPlanilla
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
