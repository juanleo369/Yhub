using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class EmpleadosBL
    {
    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)

    public class Empleado
    {
        public int ClienteId { get; set; }
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
