using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            //RUTA

            #region Categoria

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Banner";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Carpas";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Carritos";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Casetas";
            contexto.Categorias.Add(categoria4);

            var categoria5 = new Categoria();
            categoria5.Descripcion = "Food Truck";
            contexto.Categorias.Add(categoria5);

            var categoria6 = new Categoria();
            categoria6.Descripcion = "Kioscos";
            contexto.Categorias.Add(categoria6);

            var categoria7 = new Categoria();
            categoria7.Descripcion = "Muebles de metal";
            contexto.Categorias.Add(categoria7);

            var categoria8 = new Categoria();
            categoria8.Descripcion = "Rotulos";
            contexto.Categorias.Add(categoria8);

            var categoria9 = new Categoria();
            categoria9.Descripcion = "Stand";
            contexto.Categorias.Add(categoria9);

            var categoria10 = new Categoria();
            categoria10.Descripcion = "Toldos";
            contexto.Categorias.Add(categoria10);

            #endregion

            #region PreciosCuadrados
            var preciocuadrado1 = new PrecioCuadrado();
            preciocuadrado1.Valor = 650;
            preciocuadrado1.Descripcion = "Precio de Carpas Industriales";
            contexto.PrecioCuadrados.Add(preciocuadrado1);

            var preciocuadrado2 = new PrecioCuadrado();
            preciocuadrado2.Valor = 600;
            preciocuadrado2.Descripcion = "Precio de Carpas Semi-Industriales";
            contexto.PrecioCuadrados.Add(preciocuadrado2);

            var preciocuadrado3 = new PrecioCuadrado();
            preciocuadrado3.Valor = 150;
            preciocuadrado3.Descripcion = "Precio de Toldos";
            contexto.PrecioCuadrados.Add(preciocuadrado3);

            var preciocuadrado4 = new PrecioCuadrado();
            preciocuadrado4.Valor = 400;
            preciocuadrado4.Descripcion = "Precio de Casetas";
            contexto.PrecioCuadrados.Add(preciocuadrado4);

            var preciocuadrado5 = new PrecioCuadrado();
            preciocuadrado5.Valor = 400;
            preciocuadrado5.Descripcion = "Precio de Food Truck";
            contexto.PrecioCuadrados.Add(preciocuadrado5);

            var preciocuadrado6 = new PrecioCuadrado();
            preciocuadrado6.Valor = 400;
            preciocuadrado6.Descripcion = "Precio de Kioskos";
            contexto.PrecioCuadrados.Add(preciocuadrado6);

            var preciocuadrado7 = new PrecioCuadrado();
            preciocuadrado7.Valor = 80;
            preciocuadrado7.Descripcion = "Precio de Carritos";
            contexto.PrecioCuadrados.Add(preciocuadrado7);


            var preciocuadrado8 = new PrecioCuadrado();
            preciocuadrado8.Valor = 25;
            preciocuadrado8.Descripcion = "Precio de Muebles de Metal";
            contexto.PrecioCuadrados.Add(preciocuadrado8);

            var preciocuadrado9 = new PrecioCuadrado();
            preciocuadrado9.Valor = 130;
            preciocuadrado9.Descripcion = "Precio de Rotulos";
            contexto.PrecioCuadrados.Add(preciocuadrado9);

            var preciocuadrado10 = new PrecioCuadrado();
            preciocuadrado10.Valor = 25;
            preciocuadrado10.Descripcion = "Precio de Banner";
            contexto.PrecioCuadrados.Add(preciocuadrado10);

            var preciocuadrado11 = new PrecioCuadrado();
            preciocuadrado11.Valor = 120;
            preciocuadrado11.Descripcion = "Precio de Stand";
            contexto.PrecioCuadrados.Add(preciocuadrado11);

            #endregion

            #region Tipo de clientes
            var tipocliente1 = new TipoCliente();
            tipocliente1.Descripcion = "Empresa";
            contexto.TipoClientes.Add(tipocliente1);

            var tipocliente2 = new TipoCliente();
            tipocliente2.Descripcion = "Institución";
            contexto.TipoClientes.Add(tipocliente2);

            var tipocliente3 = new TipoCliente();
            tipocliente3.Descripcion = "Iglesia";
            contexto.TipoClientes.Add(tipocliente3);

            var tipocliente4 = new TipoCliente();
            tipocliente4.Descripcion = "Persona";
            contexto.TipoClientes.Add(tipocliente4);

            #endregion

            #region Empleados
            var empleado1 = new Empleado();
            empleado1.Nombre = "juan Leonardo";
            empleado1.Apellido = "Alvarado Muñoz";
            empleado1.RTN = 0;
            empleado1.Telefono = 98887457;
            empleado1.Direccion = "Barrio Santa ana";
            empleado1.Ciudad = "San Pedro Sula";
            empleado1.Correo = "juanleo369@gmail.com";
            empleado1.Fecha = new DateTime(2021, 2, 6);
            empleado1.Imagen = null;
            empleado1.Activo = true;
            empleado1.PuestoId = 5;
            empleado1.MetodoId = 7;
            empleado1.Salario = 0;
            contexto.Empleados.Add(empleado1);

            var empleado2 = new Empleado();
            empleado2.Nombre = "Claudia Isabel";
            empleado2.Apellido = "Zepeda Castillo";
            empleado2.RTN = 0;
            empleado2.Telefono = 99151346;
            empleado2.Direccion = "Barrio Santa ana";
            empleado2.Ciudad = "San Pedro Sula";
            empleado2.Correo = "zcastillo@gmail.com";
            empleado2.Fecha = new DateTime(2021, 2, 6);
            empleado2.Imagen = null;
            empleado2.Activo = true;
            empleado2.PuestoId = 2;
            empleado2.MetodoId = 5;
            empleado1.Salario = 15000;
            contexto.Empleados.Add(empleado2);
            #endregion


            #region Puestos
            var Puesto1 = new Puesto();
            Puesto1.Descripcion = "Gerente General";
            contexto.Puestos.Add(Puesto1);

            var Puesto2 = new Puesto();
            Puesto2.Descripcion = "Gerente Administrativo";
            contexto.Puestos.Add(Puesto2);

            var Puesto3 = new Puesto();
            Puesto3.Descripcion = "Tapicero";
            contexto.Puestos.Add(Puesto3);

            var Puesto4 = new Puesto();
            Puesto4.Descripcion = "Soldador";
            contexto.Puestos.Add(Puesto4);

            var Puesto5 = new Puesto();
            Puesto5.Descripcion = "Vendedor";
            contexto.Puestos.Add(Puesto5);

            var Puesto6 = new Puesto();
            Puesto4.Descripcion = "Supervisor";
            contexto.Puestos.Add(Puesto4);

            var Puesto7 = new Puesto();
            Puesto7.Descripcion = "Electricista";
            contexto.Puestos.Add(Puesto7);


            #endregion

            #region Metodo Pago 

            var MetodoPago1 = new MetodoPago();
            MetodoPago1.Descripcion = "Hora";
            contexto.MetodoPagos.Add(MetodoPago1);

            var MetodoPago2 = new MetodoPago();
            MetodoPago2.Descripcion = "Díario";
            contexto.MetodoPagos.Add(MetodoPago2);

            var MetodoPago3 = new MetodoPago();
            MetodoPago3.Descripcion = "Semanal";
            contexto.MetodoPagos.Add(MetodoPago3);

            var MetodoPago4 = new MetodoPago();
            MetodoPago4.Descripcion = "Quincenal";
            contexto.MetodoPagos.Add(MetodoPago4);

            var MetodoPago5 = new MetodoPago();
            MetodoPago5.Descripcion = "Mensual";
            contexto.MetodoPagos.Add(MetodoPago5);

            var MetodoPago7 = new MetodoPago();
            MetodoPago7.Descripcion = "Comision";
            contexto.MetodoPagos.Add(MetodoPago7);

            #endregion

            #region TipoUsuario

            var privi = new TipoUsuario();
            privi.Descripcion = "Administrador";
            contexto.TipoUsuarios.Add(privi);

            var privi1 = new TipoUsuario();
            privi1.Descripcion = "Gerente";
            contexto.TipoUsuarios.Add(privi1);

            var privi2 = new TipoUsuario();
            privi2.Descripcion = "Supervisor";
            contexto.TipoUsuarios.Add(privi2);

            #endregion

            #region Usuario
            var usuario1 = new Usuario();
            usuario1.NombUsuario = "admin";
            usuario1.Contrasena = "123";
            usuario1.TipoUsuarioId = 1;
            usuario1.EmpleadoId = 1;
            contexto.Usuarios.Add(usuario1);

            var usuario2 = new Usuario();
            usuario2.NombUsuario = "ClaudiaZCastillo";
            usuario2.Contrasena = "Claudia1974";
            usuario2.TipoUsuarioId = 2;
            usuario1.EmpleadoId = 2;
            contexto.Usuarios.Add(usuario2);

            #endregion

            base.Seed(contexto);

        }
    }

}
