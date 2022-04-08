using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class MetodoPagosBL
    {

        Contexto _contexto;
        public BindingList<MetodoPago> ListaMetodoPagos { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.

        public MetodoPagosBL()
        {
            _contexto = new Contexto();
            ListaMetodoPagos = new BindingList<MetodoPago>();
        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form

        public BindingList<MetodoPago> ObtenerMetodoPago()
        {
            _contexto.MetodoPagos.Load();

            ListaMetodoPagos = _contexto.MetodoPagos.Local.ToBindingList();
            return ListaMetodoPagos;
        }
    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class MetodoPago
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    
}
