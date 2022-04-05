using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class ProductosBL
    {
       public  BindingList<Producto> ListaProductos { get; set; }
        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.ProductoId = 1;
            producto1.Nombre = "Carpa";
            producto1.Descripcion = "Industrial";
            producto1.Tamaño_Largo = 3;
            producto1.Tamaño_Ancho = 3;
            producto1.Precio =7500;
            producto1.Activo = true;
            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.ProductoId = 2;
            producto2.Nombre = "Carpa";
            producto2.Descripcion = "Industrial";
            producto2.Tamaño_Largo = 4;
            producto2.Tamaño_Ancho = 4;
            producto2.Precio = 12500;
            producto2.Activo = true;
            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.ProductoId = 3;
            producto3.Nombre = "Carpa";
            producto3.Descripcion = "Industrial";
            producto3.Tamaño_Largo = 2;
            producto3.Tamaño_Ancho = 2;
            producto3.Precio = 5500;
            producto3.Activo = true;
            ListaProductos.Add(producto3);

        }
        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);

            if(resultado.Exitoso == false)
            {
                return resultado;
            }

            if(producto.ProductoId == 0)
            {
                producto.ProductoId = ListaProductos.Max(item => item.ProductoId) + 1;
            }
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
