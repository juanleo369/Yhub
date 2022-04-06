using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class Contexto : DbContext
    {
        public Contexto() : base("PUBLICOM")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<PrecioCuadrado> PrecioCuadrados { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoCliente> TipoClientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
        public DbSet<MetodoPago> MetodoPagos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }





    }
}
