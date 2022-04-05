using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class ProductosBL
    {
        Contexto _contexto;

       public  BindingList<Producto> ListaProductos { get; set; }
        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProductos = new BindingList<Producto>();

        }
        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();
            return ListaProductos;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);

            if(resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto(); 
            ListaProductos.Add(nuevoProducto);
        }

        public  bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if(producto.ProductoId == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "ingrese una descripción";
                resultado.Exitoso = false;

            }
            if (producto.Tamaño_Ancho <= 0)
            {
                resultado.Mensaje = "Ingrese el ancho del producto";
                resultado.Exitoso = false;

            }

            if (producto.Tamaño_Largo <= 0)
            {
                resultado.Mensaje = "Ingrese el largo del producto";
                resultado.Exitoso = false;

            }

            if (string.IsNullOrEmpty(producto.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del producto";
                resultado.Exitoso = false;

            }
            if (producto.Precio < 0)
            {
                resultado.Mensaje = "Ingrese el precio del producto";
                resultado.Exitoso = false;

            }

            return resultado;
        }
    }

    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Tamaño_Largo { get; set; }
        public double Tamaño_Ancho { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }



    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
