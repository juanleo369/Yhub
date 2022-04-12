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

        public BindingList<Puesto> ObtenerPuestos()
        {
            _contexto.Puestos.Load();

            ListaPuestos = _contexto.Puestos.Local.ToBindingList();
            return ListaPuestos;
        }

        //Codigo que sirve para Guardar datos en la base de datos
        public ResultadoPuesto GuardarPuesto(Puesto puesto)
        {
            var resultado = Validar(puesto);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        //Codigo que sirve para agregar datos en la base de datos
        public void AgregarPuesto()
        {
            var nuevoPuesto = new Puesto();
            ListaPuestos.Add(nuevoPuesto);
        }
        //Codigo que sirve para eliminar datos en la base de datos
        public bool EliminarPuesto(int id)
        {
            foreach (var puesto in ListaPuestos)
            {
                if (puesto.Id == id)
                {
                    ListaPuestos.Remove(puesto);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;

        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoPuesto Validar(Puesto puesto)
        {
            var resultado = new ResultadoPuesto();
            resultado.Exitoso = true;
            if (string.IsNullOrEmpty(puesto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese el puesto";
                resultado.Exitoso = false;

            }
           

            return resultado;
        }

    }
    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class Puesto
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
        }
    //Codigo que sirve para validar los campos que se ingresan
    public class ResultadoPuesto
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }

}
