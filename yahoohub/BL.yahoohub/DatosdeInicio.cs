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
            //Datos de inicio para las Tablas en la base de datos
            // Poner Id a los datos en cada tablas que sean foraneas
            #region Categoria

            var categoria1 = new Categoria();
            categoria1.Id = 1;
            categoria1.Descripcion = "Banner";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Id = 2;
            categoria2.Descripcion = "Carpas";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Id = 3;
            categoria3.Descripcion = "Carritos";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Id = 4;
            categoria4.Descripcion = "Casetas";
            contexto.Categorias.Add(categoria4);

            var categoria5 = new Categoria();
            categoria5.Id = 5;
            categoria5.Descripcion = "Food Truck";
            contexto.Categorias.Add(categoria5);

            var categoria6 = new Categoria();
            categoria6.Id = 6;
            categoria6.Descripcion = "Kioscos";
            contexto.Categorias.Add(categoria6);

            var categoria7 = new Categoria();
            categoria7.Id = 7;
            categoria7.Descripcion = "Muebles de metal";
            contexto.Categorias.Add(categoria7);

            var categoria8 = new Categoria();
            categoria8.Id = 8;
            categoria8.Descripcion = "Rotulos";
            contexto.Categorias.Add(categoria8);

            var categoria9 = new Categoria();
            categoria9.Id = 9;
            categoria9.Descripcion = "Stand";
            contexto.Categorias.Add(categoria9);

            var categoria10 = new Categoria();
            categoria10.Id = 10;
            categoria10.Descripcion = "Toldos";
            contexto.Categorias.Add(categoria10);

            #endregion

            #region PreciosCuadrados
            var preciocuadrado1 = new PrecioCuadrado();
            preciocuadrado1.Id = 1;
            preciocuadrado1.Valor = 650;
            preciocuadrado1.Descripcion = "Precio de Carpas Industriales";
            contexto.PrecioCuadrados.Add(preciocuadrado1);

            var preciocuadrado2 = new PrecioCuadrado();
            preciocuadrado2.Id = 2;
            preciocuadrado2.Valor = 600;
            preciocuadrado2.Descripcion = "Precio de Carpas Semi-Industriales";
            contexto.PrecioCuadrados.Add(preciocuadrado2);

            var preciocuadrado3 = new PrecioCuadrado();
            preciocuadrado3.Id = 3;
            preciocuadrado3.Valor = 150;
            preciocuadrado3.Descripcion = "Precio de Toldos";
            contexto.PrecioCuadrados.Add(preciocuadrado3);

            var preciocuadrado4 = new PrecioCuadrado();
            preciocuadrado4.Id = 4;
            preciocuadrado4.Valor = 400;
            preciocuadrado4.Descripcion = "Precio de Casetas";
            contexto.PrecioCuadrados.Add(preciocuadrado4);

            var preciocuadrado5 = new PrecioCuadrado();
            preciocuadrado5.Id = 5;
            preciocuadrado5.Valor = 400;
            preciocuadrado5.Descripcion = "Precio de Food Truck";
            contexto.PrecioCuadrados.Add(preciocuadrado5);

            var preciocuadrado6 = new PrecioCuadrado();
            preciocuadrado6.Id = 6;
            preciocuadrado6.Valor = 400;
            preciocuadrado6.Descripcion = "Precio de Kioskos";
            contexto.PrecioCuadrados.Add(preciocuadrado6);

            var preciocuadrado7 = new PrecioCuadrado();
            preciocuadrado7.Id = 7;
            preciocuadrado7.Valor = 80;
            preciocuadrado7.Descripcion = "Precio de Carritos";
            contexto.PrecioCuadrados.Add(preciocuadrado7);


            var preciocuadrado8 = new PrecioCuadrado();
            preciocuadrado8.Id = 8;
            preciocuadrado8.Valor = 25;
            preciocuadrado8.Descripcion = "Precio de Muebles de Metal";
            contexto.PrecioCuadrados.Add(preciocuadrado8);

            var preciocuadrado9 = new PrecioCuadrado();
            preciocuadrado9.Id = 9;
            preciocuadrado9.Valor = 130;
            preciocuadrado9.Descripcion = "Precio de Rotulos";
            contexto.PrecioCuadrados.Add(preciocuadrado9);

            var preciocuadrado10 = new PrecioCuadrado();
            preciocuadrado10.Id = 10;
            preciocuadrado10.Valor = 25;
            preciocuadrado10.Descripcion = "Precio de Banner";
            contexto.PrecioCuadrados.Add(preciocuadrado10);

            var preciocuadrado11 = new PrecioCuadrado();
            preciocuadrado11.Id = 11;
            preciocuadrado11.Valor = 120;
            preciocuadrado11.Descripcion = "Precio de Stand";
            contexto.PrecioCuadrados.Add(preciocuadrado11);

            #endregion

            #region Tipo de clientes
            var tipocliente1 = new TipoCliente();
            tipocliente1.Id= 1;
            tipocliente1.Descripcion = "Empresa";
            contexto.TipoClientes.Add(tipocliente1);

            var tipocliente2 = new TipoCliente();
            tipocliente2.Id = 2;
            tipocliente2.Descripcion = "Institución";
            contexto.TipoClientes.Add(tipocliente2);

            var tipocliente3 = new TipoCliente();
            tipocliente3.Id = 3;
            tipocliente3.Descripcion = "Iglesia";
            contexto.TipoClientes.Add(tipocliente3);

            var tipocliente4 = new TipoCliente();
            tipocliente4.Id = 4;
            tipocliente4.Descripcion = "Persona";
            contexto.TipoClientes.Add(tipocliente4);

            #endregion

            #region Empleados
            var empleado1 = new Empleado();
            empleado1.Id = 1;
            empleado1.Nombre = "juan Leonardo";
            empleado1.Apellido = "Alvarado Muñoz";
            empleado1.RTN = "0";
            empleado1.Telefono = "98887457";
            empleado1.Direccion = "Barrio Santa ana";
            empleado1.Ciudad = "San Pedro Sula";
            empleado1.Correo = "juanleo369@gmail.com";
            empleado1.Fecha = new DateTime(2021, 2, 6);
            empleado1.Imagen = null;
            empleado1.Activo = true;
            empleado1.PuestoId = 5;
            empleado1.MetodoId = 6;
            empleado1.Salario = 0;
            contexto.Empleados.Add(empleado1);

            var empleado2 = new Empleado();
            empleado1.Id = 2;
            empleado2.Nombre = "Claudia Isabel";
            empleado2.Apellido = "Zepeda Castillo";
            empleado2.RTN = "0";
            empleado2.Telefono = "99151346";
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
            Puesto1.Id = 1;
            Puesto1.Descripcion = "Gerente General";
            contexto.Puestos.Add(Puesto1);

            var Puesto2 = new Puesto();
            Puesto2.Id = 2;
            Puesto2.Descripcion = "Gerente Administrativo";
            contexto.Puestos.Add(Puesto2);

            var Puesto3 = new Puesto();
            Puesto3.Id = 3;
            Puesto3.Descripcion = "Tapicero";
            contexto.Puestos.Add(Puesto3);

            var Puesto4 = new Puesto();
            Puesto4.Id = 4;
            Puesto4.Descripcion = "Soldador";
            contexto.Puestos.Add(Puesto4);

            var Puesto5 = new Puesto();
            Puesto5.Id = 5;
            Puesto5.Descripcion = "Vendedor";
            contexto.Puestos.Add(Puesto5);

            var Puesto6 = new Puesto();
            Puesto6.Id = 6;
            Puesto6.Descripcion = "Supervisor";
            contexto.Puestos.Add(Puesto6);

            var Puesto7 = new Puesto();
            Puesto7.Id = 7;
            Puesto7.Descripcion = "Electricista";
            contexto.Puestos.Add(Puesto7);


            #endregion

            #region Metodo Pago 

            var MetodoPago1 = new MetodoPago();
            MetodoPago1.Id = 1;
            MetodoPago1.Descripcion = "Hora";
            contexto.MetodoPagos.Add(MetodoPago1);

            var MetodoPago2 = new MetodoPago();
            MetodoPago2.Id = 2;
            MetodoPago2.Descripcion = "Díario";
            contexto.MetodoPagos.Add(MetodoPago2);

            var MetodoPago3 = new MetodoPago();
            MetodoPago3.Id = 3;
            MetodoPago3.Descripcion = "Semanal";
            contexto.MetodoPagos.Add(MetodoPago3);

            var MetodoPago4 = new MetodoPago();
            MetodoPago4.Id = 4;
            MetodoPago4.Descripcion = "Quincenal";
            contexto.MetodoPagos.Add(MetodoPago4);

            var MetodoPago5 = new MetodoPago();
            MetodoPago5.Id = 5;
            MetodoPago5.Descripcion = "Mensual";
            contexto.MetodoPagos.Add(MetodoPago5);

            var MetodoPago6 = new MetodoPago();
            MetodoPago6.Id = 6;
            MetodoPago6.Descripcion = "Comision";
            contexto.MetodoPagos.Add(MetodoPago6);

            #endregion

            #region TipoUsuario

            var privi = new TipoUsuario();
            privi.Id = 1;
            privi.Descripcion = "Administrador";
            contexto.TipoUsuarios.Add(privi);

            var privi1 = new TipoUsuario();
            privi1.Id = 2;
            privi1.Descripcion = "Gerente";
            contexto.TipoUsuarios.Add(privi1);

            var privi2 = new TipoUsuario();
            privi2.Id = 3;
            privi2.Descripcion = "Supervisor";
            contexto.TipoUsuarios.Add(privi2);

            #endregion

            #region Usuario
            var usuario1 = new Usuario();
            usuario1.Id = 1;
            usuario1.NombUsuario = "admin";
            usuario1.Contrasena = "hola";
            usuario1.TipoUsuarioId = 1;
            usuario1.EmpleadoId = 1;
            contexto.Usuarios.Add(usuario1);

            var usuario2 = new Usuario();
            usuario2.Id = 2;
            usuario2.NombUsuario = "ClaudiaZCastillo";
            usuario2.Contrasena = "Claudia1974";
            usuario2.TipoUsuarioId = 2;
            usuario1.EmpleadoId = 2;
            contexto.Usuarios.Add(usuario2);

            #endregion

            #region Tipo Pago
            var Tipopago1 = new TipoPago();
            Tipopago1.Id= 1;
            Tipopago1.Descripcion = "60% Anticipo";
            Tipopago1.Valor = 0.60;
            contexto.TipoPagos.Add(Tipopago1);

            var Tipopago2 = new TipoPago();
            Tipopago2.Id = 2;
            Tipopago2.Descripcion = "50% Anticipo";
            Tipopago2.Valor = 0.50;
            contexto.TipoPagos.Add(Tipopago2);

            var Tipopago3 = new TipoPago();
            Tipopago3.Id = 3;
            Tipopago3.Descripcion = "40% Anticipo";
            Tipopago3.Valor = 0.50;
            contexto.TipoPagos.Add(Tipopago3);

            var Tipopago4 = new TipoPago();
            Tipopago4.Id = 4;
            Tipopago4.Descripcion = "30% Anticipo";
            Tipopago4.Valor = 0.40;
            contexto.TipoPagos.Add(Tipopago4);

            var Tipopago5 = new TipoPago();
            Tipopago5.Id = 5;
            Tipopago5.Descripcion = "30% Anticipo";
            Tipopago5.Valor = 0.30;
            contexto.TipoPagos.Add(Tipopago5);

            var Tipopago6 = new TipoPago();
            Tipopago6.Id = 6;
            Tipopago6.Descripcion = "20% Anticipo";
            Tipopago6.Valor = 0.20;
            contexto.TipoPagos.Add(Tipopago6);

            var Tipopago7 = new TipoPago();
            Tipopago7.Id = 7;
            Tipopago7.Descripcion = "10% Anticipo";
            Tipopago7.Valor = 0.10;
            contexto.TipoPagos.Add(Tipopago7);

            var Tipopago8 = new TipoPago();
            Tipopago8.Id = 8;
            Tipopago8.Descripcion = "5% Anticipo";
            Tipopago8.Valor = 0.05;
            contexto.TipoPagos.Add(Tipopago8);

            var Tipopago9 = new TipoPago();
            Tipopago9.Id = 9;
            Tipopago9.Descripcion = "Pago Completo";
            Tipopago9.Valor = 0;
            contexto.TipoPagos.Add(Tipopago9);


            #endregion

            #region Estado Pedido
            var EstadoPedido = new EstadoPedido();
            EstadoPedido.Id = 1;
            EstadoPedido.Descripcion = "Cotizacion";
            contexto.EstadoPedidos.Add(EstadoPedido);

            var EstadoPedido1 = new EstadoPedido();
            EstadoPedido1.Id = 2;
            EstadoPedido1.Descripcion = "Pedido";
            contexto.EstadoPedidos.Add(EstadoPedido1);

            var EstadoPedido2 = new EstadoPedido();
            EstadoPedido2.Id = 3;
            EstadoPedido2.Descripcion = "En Fabricación";
            contexto.EstadoPedidos.Add(EstadoPedido2);

            var EstadoPedido3 = new EstadoPedido();
            EstadoPedido3.Id = 4;
            EstadoPedido3.Descripcion = "Entregado";
            contexto.EstadoPedidos.Add(EstadoPedido3);

            #endregion

            #region impuesto

            var impuesto1 = new Impuesto();
            impuesto1.Id = 1;
            impuesto1.Descripcion = "15%";
            impuesto1.Valor = 0.15;
            contexto.Impuestos.Add(impuesto1);

            var impuesto2 = new Impuesto();
            impuesto2.Id = 2;
            impuesto2.Descripcion = "12%";
            impuesto2.Valor = 0.12;
            contexto.Impuestos.Add(impuesto2);

            var impuesto3 = new Impuesto();
            impuesto3.Id = 3;
            impuesto3.Descripcion = "0%";
            impuesto3.Valor = 0;
            contexto.Impuestos.Add(impuesto3);
            #endregion

 





            base.Seed(contexto);

        }
    }

}
