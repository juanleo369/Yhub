using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class SeguridadBL
    {
        Contexto _contexto;
        public BindingList<Usuario> ListaSeguridad { get; set; }

        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListaSeguridad = new BindingList<Usuario>();
        }
        public BindingList<Usuario> ObtenerUsuario()
        {
            _contexto.Usuarios.Load();

            ListaSeguridad = _contexto.Usuarios.Local.ToBindingList();
            return ListaSeguridad;
        }


        // GUARDAD
        public ResultadoUsuario GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        //AGREGAR
        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();
            ListaSeguridad.Add(nuevoUsuario);
        }

        //ELIMINAR
        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListaSeguridad)
            {
                if (usuario.Id == id)
                {
                    ListaSeguridad.Remove(usuario);
                    _contexto.SaveChanges();

                    return true;
                }
            }
            return false;
        }

        //VALIDACION
        private ResultadoUsuario Validar(Usuario usuario)
        {
            var resultado = new ResultadoUsuario();
            resultado.Exitoso = true;

            if (usuario == null)
            {
                resultado.Mensaje = "Ingrese un usuario valido";
                resultado.Exitoso = false;

                return resultado;
            }

            //SEGURIDAD
            if (string.IsNullOrEmpty(usuario.NombUsuario) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre de Usuario";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(usuario.Contrasena) == true)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese una contraseña";
            }

            if (usuario.TipoUsuarioId <= 0)
            {
                resultado.Mensaje = "Seleccion un Tipo de Usuario";
                resultado.Exitoso = false;
            }

            return resultado;
        }


        public Usuario Autorizar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();
            _contexto.Usuarios.Include("TipoUsuario").Load();

            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.NombUsuario && contrasena == usuarioDB.Contrasena)
                {
                    return usuarioDB;

                }
            }

            return null;
        }
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string NombUsuario { get; set; }
        public string Contrasena { get; set; }
        public int TipoUsuarioId { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }


    }

    public class ResultadoUsuario
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
