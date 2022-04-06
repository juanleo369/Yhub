using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class PuestosBL
    {
        Contexto _contexto;
        public BindingList<Puesto> ListaPuestos { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.

        public PuestosBL()
        {
            _contexto = new Contexto();
            ListaPuestos = new BindingList<Puesto>();
        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form

        public BindingList<Puesto> ObtenerPuesto()
        {
            _contexto.Puestos.Load();

            ListaPuestos = _contexto.Puestos.Local.ToBindingList();
            return ListaPuestos;
        }
    }
        //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
        public class Puesto
        {
            public int PuestoId { get; set; }
            public string Descripcion { get; set; }
        }

        
    }
