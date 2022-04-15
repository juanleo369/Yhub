using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class ClientesBL
    {      
        //Variable local de la base y Variable de la lista

        Contexto _contexto;
        public BindingList<Cliente> ListaClientes { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();
        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();

            ListaClientes = _contexto.Clientes.Local.ToBindingList();
            return ListaClientes;
        }


        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }
        //Codigo que sirve para Guardar datos en la base de datos

        public ResultadoCliente GuardarCliente(Cliente cliente)
        {
            var resultadocliente = Validar(cliente);

            if (resultadocliente.Exitoso == false)
            {
                return resultadocliente;
            }

            _contexto.SaveChanges();
            resultadocliente.Exitoso = true;
            return resultadocliente;
        }

        //Codigo que sirve para agregar datos en la base de datos
        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }

        //Codigo que sirve para eliminar datos en la base de datos
        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoCliente Validar(Cliente cliente)
        {
            var resultado = new ResultadoCliente();
            resultado.Exitoso = true;
            if (cliente == null)
            {
                resultado.Mensaje = "Ingrese un cliente valido";
                resultado.Exitoso = false;

                return resultado;
            }
            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "ingrese el nombre del Cliente";
                resultado.Exitoso = false;

            }
            if (string.IsNullOrEmpty(cliente.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese la dirección";
                resultado.Exitoso = false;

            }

            if (string.IsNullOrEmpty(cliente.Deparmento) == true)
            {
                resultado.Mensaje = "Ingrese el Departamento";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Ciudad) == true)
            {
                resultado.Mensaje = "Ingrese la ciudad";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(cliente.Correo) == true)
            {
                resultado.Mensaje = "Ingrese el correo";
                resultado.Exitoso = false;

            }

            return resultado;
        }

    }


    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)

    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string RTN { get; set; }
        public  int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Deparmento { get; set; }
        public string Ciudad { get; set; }
        public string Correo { get; set; }
        public int TipoClienteId { get; set; }
        public  TipoCliente TipoCliente { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Imagen { get; set; }
        public bool  Activo { get; set; }

        //para inicializar el cliente marcado el activo y fecha actual
        public Cliente()
        {
            Fecha = DateTime.Now;
            Activo = true;
        }
    }
 
    //Codigo que sirve para validar los campos que se ingresan

    public class ResultadoCliente
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }


}
