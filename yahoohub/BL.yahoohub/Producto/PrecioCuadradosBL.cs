using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class PrecioCuadradosBL
    {
        //Variable local de la base y Variable de la lista

        Contexto _contexto;
        public BindingList<PrecioCuadrado> ListaPrecioCuadrados { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.

        public PrecioCuadradosBL()
        {
            _contexto = new Contexto();
            ListaPrecioCuadrados = new BindingList<PrecioCuadrado>();
        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form

        public BindingList<PrecioCuadrado> ObtenerPrecioCuadrados()
        {
            _contexto.PrecioCuadrados.Load();

            ListaPrecioCuadrados = _contexto.PrecioCuadrados.Local.ToBindingList();
            return ListaPrecioCuadrados;
        }

        //Codigo que sirve para Guardar datos en la base de datos

        public ResultadoPrecio GuardarPrecioCuadrado(PrecioCuadrado precioCuadrado)
        {
            var resultadoprecio = Validar(precioCuadrado);

            if (resultadoprecio.Exitoso == false)
            {
                return resultadoprecio;
            }

            _contexto.SaveChanges();
            resultadoprecio.Exitoso = true;
            return resultadoprecio;
        }

        //Codigo que sirve para agregar datos en la base de datos
        public void AgregarPrecioCuadrado()
        {
            var nuevoPrecioCuadrado = new PrecioCuadrado();
            ListaPrecioCuadrados.Add(nuevoPrecioCuadrado);
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
        public bool EliminarPrecioCuadrado(int id)
        {
            foreach (var preciocuadrado in ListaPrecioCuadrados)
            {
                if (preciocuadrado.Id == id)
                {
                    ListaPrecioCuadrados.Remove(preciocuadrado);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoPrecio Validar(PrecioCuadrado precioCuadrado)
        {
            var resultado = new ResultadoPrecio();
            resultado.Exitoso = true;

            if (precioCuadrado == null)
            {
                resultado.Mensaje = "Ingrese un precio cuadrado valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(precioCuadrado.Descripcion) == true)
            {
                resultado.Mensaje = "ingrese una descripción";
                resultado.Exitoso = false;

            }
            if (precioCuadrado.Valor <= 0)
            {
                resultado.Mensaje = "Ingrese el valor";
                resultado.Exitoso = false;

            }


            return resultado;
        }

    }


    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)

    public class PrecioCuadrado
    {
        public int Id { get; set; }
        public int Valor { get; set; }
        public string Descripcion { get; set; }
    }

    //Codigo que sirve para validar los campos que se ingresan

    public class ResultadoPrecio
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}