using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class OrdenesBL
    {
        //Variable local de la base y Variable de la lista
        Contexto _contexto;

        public BindingList<Orden> ListaOrdenes { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public OrdenesBL()
        {
            _contexto = new Contexto();
            ListaOrdenes = new BindingList<Orden>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Orden> ObtenerOrdenes()
        {
            _contexto.Ordenes.Load();
            ListaOrdenes = _contexto.Ordenes.Local.ToBindingList();
            return ListaOrdenes;
        }


        //Codigo que sirve para Guardar datos en la base de datos
        public ResultadoOrden GuardarOrden(Orden orden)
        {
            var resultadoorden = Validar(orden);

            if (resultadoorden.Exitoso == false)
            {
                return resultadoorden;
            }

            _contexto.SaveChanges();
            resultadoorden.Exitoso = true;
            return resultadoorden;
        }

        //Codigo que sirve para agregar datos en la base de datos
        public void AgregarOrden()
        {
            var nuevoOrden = new Orden();
            ListaOrdenes.Add(nuevoOrden);
        }

        //Codigo que sirve para eliminar datos en la base de datos
        public bool EliminarOrden(int id)
        {
            foreach (var orden in ListaOrdenes)
            {
                if (orden.Id == id)
                {
                    ListaOrdenes.Remove(orden);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoOrden Validar(Orden orden)
        {
            var resultado = new ResultadoOrden();
            resultado.Exitoso = true;

            if (orden.EmpleadoId < 0)
            {
                resultado.Mensaje = "Ingrese un Empleado";
                resultado.Exitoso = false;

            }

            if (orden.ClienteId < 0)
            {
                resultado.Mensaje = "Ingrese un Cliente";
                resultado.Exitoso = false;
            }

            if (orden.TipoPagoId < 0)
            {
                resultado.Mensaje = "Ingrese un tipo d pago";
                resultado.Exitoso = false;
            }
            if (orden.EmpleadoId < 0)
            {
                resultado.Mensaje = "Ingrese un empleado";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(orden.Observacion) == true)
            {
                resultado.Mensaje = "Ingrese una observación";
                resultado.Exitoso = false;

            }
            if (orden.Descuento < 0)
            {
                resultado.Mensaje = "Ingrese un Descuento";
                resultado.Exitoso = false;
            }
            if (orden.Subtotal < 0)
            {
                resultado.Mensaje = "Ingrese un Subtotal";
                resultado.Exitoso = false;
            }
            if (orden.ImpuestoId < 0)
            {
                resultado.Mensaje = "Ingrese un Impuesto";
                resultado.Exitoso = false;
            }
            if (orden.Total < 0)
            {
                resultado.Mensaje = "Ingrese un Total";
                resultado.Exitoso = false;
            }

            if (orden.EstadoPedidoId < 0)
            {
                resultado.Mensaje = "Ingrese un empleado";
                resultado.Exitoso = false;
            }
            return resultado;
        }

    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class Orden
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public DateTime Fecha_Orden { get; set; }
        public DateTime Fecha_Entrega { get; set; }
        public string Observacion { get; set; }
        public double Descuento { get; set; }
        public double Subtotal { get; set; }
        public int ImpuestoId { get; set; }
        public Impuesto Impuesto { get; set; }
        public double ISV { get; set; }
        public double Total { get; set; }
        public int TipoPagoId { get; set; }
        public TipoPago TipoPago { get; set; }
        public double Abono { get; set; }
        public double Saldo_Pendiente { get; set; }
        public  int EstadoPedidoId { get; set; }
        public EstadoPedido EstadoPedido { get; set; }
        public bool  Cotizacion { get; set; }
        public bool Pedido { get; set; }
    }
    //Codigo que sirve para validar los campos que se ingresan
    public class ResultadoOrden
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
