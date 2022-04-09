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
        //Variable local de la base y Variable de la lista

        Contexto _contexto;

       public  BindingList<Producto> ListaProductos { get; set; }
        
        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProductos = new BindingList<Producto>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();
            return ListaProductos;
        }

        //Codigo que sirve para Guardar datos en la base de datos

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

        //Codigo que sirve para agregar datos en la base de datos

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto(); 
            ListaProductos.Add(nuevoProducto);
        }
        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }
        //Codigo que sirve para eliminar datos en la base de datos

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if(producto.Id == id)
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
            if (producto.CategoriaId < 0)
            {
                resultado.Mensaje = "Ingrese una categoria del producto";
                resultado.Exitoso = false;

            }
            if (producto.PrecioCuadradoId < 0)
            {
                resultado.Mensaje = "Ingrese el precio de la medida del producto";
                resultado.Exitoso = false;

            }

            return resultado;
        }
    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)

    public class Producto
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int  PrecioCuadradoId{ get; set; }
        public PrecioCuadrado PrecioCuadrado{ get; set; }
        public double Tamaño_Largo { get; set; }
        public double Tamaño_Ancho { get; set; }
        public double Precio { get; set; }
        public byte[] Imagen { get; set; }
        public bool Activo { get; set; }



    }
    //Codigo que sirve para validar los campos que se ingresan

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
