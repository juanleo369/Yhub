using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class TipoClientesBL
    {
        Contexto _contexto;
        public BindingList<TipoCliente> ListaTipoClientes { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.

        public TipoClientesBL()
        {
            _contexto = new Contexto();
            ListaTipoClientes = new BindingList<TipoCliente>();
        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form

        public BindingList<TipoCliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();

            ListaTipoClientes = _contexto.TipoClientes.Local.ToBindingList();
            return ListaTipoClientes;
        }
    }

        //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
        public class TipoCliente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }


    }

}
