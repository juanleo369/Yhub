using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class ProveedoresBL
    {
        Contexto _contexto;
        public BindingList<Proveedor> ListaProveedores { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public ProveedoresBL()
        {
            _contexto = new Contexto();
            ListaProveedores = new BindingList<Proveedor>();
        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Proveedor> ObtenerProveedores()
        {
            _contexto.Proveedores.Load();

            ListaProveedores = _contexto.Proveedores.Local.ToBindingList();
            return ListaProveedores;
        }

        //Codigo que sirve para Guardar datos en la base de datos
        public ResultadoProveedor GuardarProveedor(Proveedor proveedor)
        {
            var resultadoproveedor = Validar(proveedor);

            if (resultadoproveedor.Exitoso == false)
            {
                return resultadoproveedor;
            }

            _contexto.SaveChanges();
            resultadoproveedor.Exitoso = true;
            return resultadoproveedor;
        }

        //Codigo que sirve para agregar datos en la base de datos
        public void AgregarProveedor()
        {
            var nuevoProveedor = new Proveedor();
            ListaProveedores.Add(nuevoProveedor);
        }

        //Codigo que sirve para eliminar datos en la base de datos
        public bool EliminarProveedor(int id)
        {
            foreach (var proveedor in ListaProveedores)
            {
                if (proveedor.Id == id)
                {
                    ListaProveedores.Remove(proveedor);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoProveedor Validar(Proveedor proveedor)
        {
            var resultado = new ResultadoProveedor();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(proveedor.Nombre) == true)
            {
                resultado.Mensaje = "ingrese el nombre del proveedor";
                resultado.Exitoso = false;

            }
            if (string.IsNullOrEmpty(proveedor.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese la dirección";
                resultado.Exitoso = false;

            }

            if (string.IsNullOrEmpty(proveedor.Deparmento) == true)
            {
                resultado.Mensaje = "Ingrese el Departamento";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(proveedor.Ciudad) == true)
            {
                resultado.Mensaje = "Ingrese la ciudad";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(proveedor.Correo) == true)
            {
                resultado.Mensaje = "Ingrese el correo";
                resultado.Exitoso = false;

            }

            return resultado;
        }

    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int RTN { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Deparmento { get; set; }
        public string Ciudad { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Imagen { get; set; }
        public bool Activo { get; set; }


    }

    //Codigo que sirve para validar los campos que se ingresan
    public class ResultadoProveedor
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
