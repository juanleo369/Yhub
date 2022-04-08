using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class EmpleadosBL
    {
        //Variable local de la base y Variable de la lista

        Contexto _contexto;

        public BindingList<Empleado> ListaEmpleados { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public EmpleadosBL()
        {
            _contexto = new Contexto();
            ListaEmpleados = new BindingList<Empleado>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Empleado> ObtenerEmpleados()
        {
            _contexto.Empleados.Load();
            ListaEmpleados = _contexto.Empleados.Local.ToBindingList();
            return ListaEmpleados;
        }

        //Codigo que sirve para Guardar datos en la base de datos
        public ResultadoEmpleado GuardarEmpleado(Empleado empleado)
        {
            var resultado = Validar(empleado);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        //Codigo que sirve para agregar datos en la base de datos
        public void AgregarEmpleado()
        {
            var nuevoEmpleado = new Empleado();
            ListaEmpleados.Add(nuevoEmpleado);
        }

        //Codigo que sirve para eliminar datos en la base de datos
        public bool EliminarEmpleado(int id)
        {
            foreach (var empleado in ListaEmpleados)
            { 
                if (empleado.Id == id)
                {
                    ListaEmpleados.Remove(empleado);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoEmpleado Validar(Empleado empleado)
        {
            var resultado = new ResultadoEmpleado();
            resultado.Exitoso = true;
            if (string.IsNullOrEmpty(empleado.Nombre) == true)
            {
                resultado.Mensaje = "ingrese el nombre del Cliente";
                resultado.Exitoso = false;

            }
            if (string.IsNullOrEmpty(empleado.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese la dirección";
                resultado.Exitoso = false;

            }

            if (string.IsNullOrEmpty(empleado.Deparmento) == true)
            {
                resultado.Mensaje = "Ingrese el Departamento";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(empleado.Ciudad) == true)
            {
                resultado.Mensaje = "Ingrese la ciudad";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(empleado.Correo) == true)
            {
                resultado.Mensaje = "Ingrese el correo";
                resultado.Exitoso = false;

            }

            return resultado;
        }
    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int RTN { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Deparmento { get; set; }
        public string Ciudad { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Imagen { get; set; }
        public bool Activo { get; set; }
        public int PuestoId { get; set; }
        public Puesto Puesto { get; set; }
        public int MetodoId { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public double Salario { get; set; }


    }

    //Codigo que sirve para validar los campos que se ingresan
    public class ResultadoEmpleado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
