using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class ComprasBL
    {
        //Variable local de la base y Variable de la lista

        Contexto _contexto;

        public BindingList<Compra> ListaCompras { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public ComprasBL()
        {
            _contexto = new Contexto();
            ListaCompras = new BindingList<Compra>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Compra> ObtenerCompras()
        {
            _contexto.Compras.Load();
            ListaCompras = _contexto.Compras.Local.ToBindingList();
            return ListaCompras;
        }

        //Codigo que sirve para Guardar datos en la base de datos

        public ResultadoCompra GuardarCompra(Compra compra)
        {
            var resultado = Validar(compra);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        //Codigo que sirve para agregar datos en la base de datos

        public void AgregarCompra()
        {
            var nuevoCompra = new Compra();
            ListaCompras.Add(nuevoCompra);
        }

        //Codigo que sirve para eliminar datos en la base de datos

        public bool EliminarCompra(int id)
        {
            foreach (var compra in ListaCompras)
            {
                if (compra.Id == id)
                {
                    ListaCompras.Remove(compra);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoCompra Validar(Compra compra)
        {
            var resultado = new ResultadoCompra();
            resultado.Exitoso = true;
            if (string.IsNullOrEmpty(compra.Observacion) == true)
            {
                resultado.Mensaje = "ingrese una observación";
                resultado.Exitoso = false;

            }       
          return resultado;
        }
    }
   
    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class Compra
    {
        public int Id { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Observacion { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public int CDetalleId { get; set; }
        public CDetalle CDetalle { get; set; }
        public double Descuento { get; set; }
        public double Subtotal { get; set; }
        public double ISV { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }


    }

    //Codigo que sirve para validar los campos que se ingresan

    public class ResultadoCompra
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }

}
