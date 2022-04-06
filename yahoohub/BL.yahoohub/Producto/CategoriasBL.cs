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
        
   
    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }


    }

    //Codigo que sirve para validar los campos que se ingresan
    public class ResultadoCategoria
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}