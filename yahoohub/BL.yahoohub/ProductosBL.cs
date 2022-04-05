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
}
