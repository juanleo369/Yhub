using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class EstadoPedidosBL
    {
        //Variable local de la base y Variable de la lista
        Contexto _contexto;

        public BindingList<EstadoPedido> ListaEstadoPedidos { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public EstadoPedidosBL()
        {
            _contexto = new Contexto();
            ListaEstadoPedidos = new BindingList<EstadoPedido>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<EstadoPedido> ObtenerEstadoPedidos()
        {
            _contexto.EstadoPedidos.Load();
            ListaEstadoPedidos = _contexto.EstadoPedidos.Local.ToBindingList();
            return ListaEstadoPedidos;
        }
    }
    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class EstadoPedido
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

}
