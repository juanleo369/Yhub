using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class CategoriasBL
    {
        //Variable local de la base y Variable de la lista

        Contexto _contexto;
        public BindingList<Categoria> ListaCategorias { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.

        public CategoriasBL()
        {
            _contexto = new Contexto();
            ListaCategorias = new BindingList<Categoria>();
        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form

        public BindingList<Categoria> ObtenerCategorias()
        {
            _contexto.Categorias.Load();

            ListaCategorias = _contexto.Categorias.Local.ToBindingList();
            return ListaCategorias;
        }

        public ResultadoCategoria GuardarCategoria(Categoria categoria)
        {
            var resultado = Validar(categoria);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        //Codigo que sirve para agregar datos en la base de datos

        public void AgregarCategoria()
        {
            var nuevoCategoria = new Categoria();
            ListaCategorias.Add(nuevoCategoria);
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

        public bool EliminarCategoria(int id)
        {
            foreach (var categoria in ListaCategorias)
            {
                if (categoria.Id == id)
                {
                    ListaCategorias.Remove(categoria);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoCategoria Validar(Categoria categoria)
        {
            var resultado = new ResultadoCategoria();
            resultado.Exitoso = true;
            if (categoria == null)
            {
                resultado.Mensaje = "Ingrese una categoria valida";
                resultado.Exitoso = false;

                return resultado;
            }
            if (string.IsNullOrEmpty(categoria.Descripcion) == true)
            {
                resultado.Mensaje = "ingrese una descripción";
                resultado.Exitoso = false;

            }
           

            return resultado;
        }

    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }


    }

    //Codigo que sirve para validar los campos que se ingresan
    public class ResultadoCategoria
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}