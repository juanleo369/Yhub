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
            _contexto.Compras.Include("CompraDetalle").Load();
            ListaCompras = _contexto.Compras.Local.ToBindingList();
            return ListaCompras;

            
        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Compra> ObtenerCompras(int id)
        {

            _contexto.Compras.Find(id);
            _contexto.Compras.Include("CompraDetalle").Load();
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

        //Codigo que sirve para agregar materiales a la tabla compra detalle

        public void AgregarCompraDetalle(Compra compra)
        {
            if (compra != null)
            {
                var nuevoDetalle = new CompraDetalle();
                compra.CompraDetalle.Add(nuevoDetalle);
            }
        }

        //Codigo que sirve para remover materiales a la tabla compra detalle

        public void RemoverCompraDetalle(Compra compra, CompraDetalle compraDetalle)
        {
            if (compra != null && compraDetalle != null)
            {
                compra.CompraDetalle.Remove(compraDetalle);
            }
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

        //Codigo que sirve para calcular los precios de los productos ingresados y sacar los precios
        public void CalcularOrden(Compra compra, double impuesto, double descuento)
        {
            if (compra != null)
            {
                double subtotal = 0;

                foreach (var detalle in compra.CompraDetalle)
                {
                    var material = _contexto.Productos.Find(detalle.MaterialId);
                    if (material != null)
                    {
                        detalle.Precio = material.Precio;
                        detalle.Total = detalle.Cantidad * material.Precio;

                        subtotal += detalle.Total;
                    }
                }

                compra.Subtotal = subtotal;
                compra.ISV = subtotal * impuesto;
                compra.Total = subtotal + compra.ISV - descuento;
            }


        }
        public bool AnularCompra(int id)
        {
            foreach (var compra in ListaCompras)
            {
                if (compra.Id == id)
                {
                    compra.Activo = false;

                    //CalcularExistencia(factura);

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

            if (compra == null)
            {
                resultado.Mensaje = "Ingrese una compra valida";
                resultado.Exitoso = false;

                return resultado;
            }


            if (compra.Activo == false)
            {
                resultado.Mensaje = "La compra esta anulada y no se pueden realizar cambios en ella";
                resultado.Exitoso = false;
            }

            if (compra.EmpleadoId < 0)
            {
                resultado.Mensaje = "Ingrese un Empleado";
                resultado.Exitoso = false;

            }

            if (compra.ProveedorId < 0)
            {
                resultado.Mensaje = "Ingrese un Proveedor";
                resultado.Exitoso = false;

            }

            if (string.IsNullOrEmpty(compra.Observacion) == true)
            {
                resultado.Mensaje = "Ingrese una observación";
                resultado.Exitoso = false;

            }

            if (compra.Descuento < 0)
            {
                resultado.Mensaje = "Ingrese un Descuento";
                resultado.Exitoso = false;
            }
            if (compra.Subtotal < 0)
            {
                resultado.Mensaje = "Ingrese un Subtotal";
                resultado.Exitoso = false;
            }
            if (compra.ImpuestoId < 0)
            {
                resultado.Mensaje = "Ingrese un Impuesto";
                resultado.Exitoso = false;
            }
            if (compra.Total < 0)
            {
                resultado.Mensaje = "Ingrese un Total";
                resultado.Exitoso = false;
            }

            if (compra.CompraDetalle.Count == 0)
            {
                resultado.Mensaje = "Ingrese un material a la Compra";
                resultado.Exitoso = false;
            }
            foreach (var detalle in compra.CompraDetalle)
            {
                if (detalle.MaterialId == 0)
                {
                    resultado.Mensaje = "Seleccione materiales validos";
                    resultado.Exitoso = false;
                }
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
        public BindingList<CompraDetalle> CompraDetalle { get; set; }     
        public double Descuento { get; set; }
        public double Subtotal { get; set; }
        public int ImpuestoId { get; set; }
        public Impuesto Impuesto { get; set; }
        public double ISV { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        //para inicializar el cliente marcado el activo y fecha actual
        public Compra()
        {
            CompraDetalle = new BindingList<CompraDetalle>();

            FechaCompra = DateTime.Now;
            Activo = true;
        }
    }

    //Codigo que sirve para validar los campos que se ingresan

    public class ResultadoCompra
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
    public class CompraDetalle
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public CompraDetalle()
        {
            Cantidad = 1;
        }

    }
}
