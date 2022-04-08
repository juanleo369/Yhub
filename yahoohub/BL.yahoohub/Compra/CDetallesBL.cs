using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class CDetallesBL
    {
        //Variable local de la base y Variable de la lista

        Contexto _contexto;

        public BindingList<CDetalle> ListaCDetalles { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public CDetallesBL()
        {
            _contexto = new Contexto();
            ListaCDetalles = new BindingList<CDetalle>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<CDetalle> ObtenerCDetalles()
        {
            _contexto.CDetalles.Load();
            ListaCDetalles = _contexto.CDetalles.Local.ToBindingList();
            return ListaCDetalles;
        }

        //Codigo que sirve para Guardar datos en la base de datos

        public ResultadoCDetalle GuardarCDetalle(CDetalle cdetalles)
        {
            var resultado = Validar(cdetalles);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        //Codigo que sirve para agregar datos en la base de datos

        public void AgregarCDetalle()
        {
            var nuevoCDetalles = new CDetalle();
            ListaCDetalles.Add(nuevoCDetalles);
        }

        //Codigo que sirve para eliminar datos en la base de datos

        public bool EliminarCDetalle(int id)
        {
            foreach (var cdetalle in ListaCDetalles)
            {
                if (cdetalle.Id == id)
                {
                    ListaCDetalles.Remove(cdetalle);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoCDetalle Validar(CDetalle cdetalle)
        {
            var resultado = new ResultadoCDetalle();
            resultado.Exitoso = true;
            if (cdetalle.MaterialId <=0)
            {
                resultado.Mensaje = "ingrese un material";
                resultado.Exitoso = false;

            }
            if (cdetalle.Cantidad <= 0)
            {
                resultado.Mensaje = "ingrese la cantidad";
                resultado.Exitoso = false;

            }
            return resultado;
        }
    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class CDetalle
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }


    }

    //Codigo que sirve para validar los campos que se ingresan

    public class ResultadoCDetalle
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
