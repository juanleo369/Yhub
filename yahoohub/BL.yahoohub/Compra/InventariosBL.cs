using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class InventariosBL
    {
        //Variable local de la base y Variable de la lista
        Contexto _contexto;

        public BindingList<Inventario> ListaInventarios { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public InventariosBL()
        {
            _contexto = new Contexto();
            ListaInventarios = new BindingList<Inventario>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Inventario> ObtenerInventarios()
        {
            _contexto.Inventarios.Load();
            ListaInventarios = _contexto.Inventarios.Local.ToBindingList();
            return ListaInventarios;
        }

        //Codigo que sirve para Guardar datos en la base de datos
        public ResultadoInventario GuardarInventario(Inventario inventario)
        {
            var resultado = Validar(inventario);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        //Codigo que sirve para agregar datos en la base de datos
        public void AgregarInventario()
        {
            var nuevoInventarios = new Inventario();
            ListaInventarios.Add(nuevoInventarios);
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
        public bool EliminarInventario(int id)
        {
            foreach (var inventario in ListaInventarios)
            {
                if (inventario.Id == id)
                {
                    ListaInventarios.Remove(inventario);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoInventario Validar(Inventario inventarios)
        {
            var resultado = new ResultadoInventario();
            resultado.Exitoso = true;
             
            if (inventarios.Cantidad <= 0)
            {
                resultado.Mensaje = "ingrese la cantidad del material";
                resultado.Exitoso = false;

            }

            if (inventarios.MaterialId <= 0)
            {
                resultado.Mensaje = "ingrese el material";
                resultado.Exitoso = false;

            }

            if (inventarios.EmpleadoId <= 0)
            {
                resultado.Mensaje = "ingrese el empleado";
                resultado.Exitoso = false;

            }

            return resultado;
        }
    }
    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class Inventario
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public DateTime FechaSalida { get; set; }
        public int Cantidad { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        public Inventario()
        {
            FechaSalida = DateTime.Now;
        }
    }

    //Codigo que sirve para validar los campos que se ingresan

    public class ResultadoInventario
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
