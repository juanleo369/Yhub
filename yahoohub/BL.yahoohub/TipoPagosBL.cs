using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class TipoPagosBL
    {
        //Variable local de la base y Variable de la lista
        Contexto _contexto;

        public BindingList<TipoPago> ListaTipoPagos { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public TipoPagosBL()
        {
            _contexto = new Contexto();
            ListaTipoPagos = new BindingList<TipoPago>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<TipoPago> ObtenerTipoPagos()
        {
            _contexto.TipoPagos.Load();
            ListaTipoPagos = _contexto.TipoPagos.Local.ToBindingList();
            return ListaTipoPagos;
        }

    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class TipoPago
    {
        public int TipoPagoId { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }

    }

}
