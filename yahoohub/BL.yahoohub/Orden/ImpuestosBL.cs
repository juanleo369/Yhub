using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
   public class ImpuestosBL
    {
        //Variable local de la base y Variable de la lista
        Contexto _contexto;

        public BindingList<Impuesto> ListaImpuestos { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public ImpuestosBL()
        {
            _contexto = new Contexto();
            ListaImpuestos = new BindingList<Impuesto>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Impuesto> ObtenerImpuestos()
        {
            _contexto.Impuestos.Load();
            ListaImpuestos = _contexto.Impuestos.Local.ToBindingList();
            return ListaImpuestos;
        }


    }
    public class Impuesto
    {
        public int ImpuestoId { get; set; }
        public double Valor { get; set; }
        public string Descripcion { get; set; }
    }
}
