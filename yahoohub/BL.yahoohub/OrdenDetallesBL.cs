using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class OrdenDetallesBL
    {
        //Variable local de la base y Variable de la lista
        Contexto _contexto;

        public BindingList<OrdenDetalle> ListaOrdenDetalles { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public OrdenDetallesBL()
        {
            _contexto = new Contexto();
            ListaOrdenDetalles = new BindingList<OrdenDetalle>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<OrdenDetalle> ObtenerOrdenDetalles()
        {
            _contexto.OrdenDetalles.Load();
            ListaOrdenDetalles = _contexto.OrdenDetalles.Local.ToBindingList();
            return ListaOrdenDetalles;
        }


        //Codigo que sirve para Guardar datos en la base de datos
        public ResultadoOrdenDetalle GuardarOrdenDetalle(OrdenDetalle ordendetalle)
        {
            var resultadoordendetalle = Validar(ordendetalle);

            if (resultadoordendetalle.Exitoso == false)
            {
                return resultadoordendetalle;
            }

            _contexto.SaveChanges();
            resultadoordendetalle.Exitoso = true;
            return resultadoordendetalle;
        }

        //Codigo que sirve para agregar datos en la base de datos
        public void AgregarOrdenDetalle()
        {
            var nuevoOrdenDetalle = new OrdenDetalle();
            ListaOrdenDetalles.Add(nuevoOrdenDetalle);
        }

        //Codigo que sirve para eliminar datos en la base de datos
        public bool EliminarOrdenDetalle(int id)
        {
            foreach (var ordendetalle in ListaOrdenDetalles)
            {
                if (ordendetalle.OrdenDetalleId == id)
                {
                    ListaOrdenDetalles.Remove(ordendetalle);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoOrdenDetalle Validar(OrdenDetalle ordendetalle)
        {
            var resultado = new ResultadoOrdenDetalle();
            resultado.Exitoso = true;

            if (ordendetalle.OrdenId < 0)
            {
                resultado.Mensaje = "Ingrese una orden";
                resultado.Exitoso = false;

            }

            if (ordendetalle.ProductoId < 0)
            {
                resultado.Mensaje = "Ingrese un producto";
                resultado.Exitoso = false;
            }

            if (ordendetalle.Cantidad < 0)
            {
                resultado.Mensaje = "Ingrese una cantidad";
                resultado.Exitoso = false;
            }
            if (ordendetalle.Precio < 0)
            {
                resultado.Mensaje = "Ingrese el Precio";
                resultado.Exitoso = false;

            }

            return resultado;
        }

    }
    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class OrdenDetalle
    {
        public int OrdenDetalleId { get; set; }
        public int OrdenId { get; set; }
        public Orden Orden { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
    public class ResultadoOrdenDetalle
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
