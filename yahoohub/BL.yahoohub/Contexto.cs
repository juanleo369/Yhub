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
        public Contexto(): base("PUBLICOM")
        {

        }

protected override void OnModelCreating(DbModelBuilder modelBuilder)
{
       
    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    Database.SetInitializer(new DatosdeInicio());
}

    public DbSet<Producto> Productos { get; set; }
    public DbSet<PrecioCuadrado> PrecioCuadrados { get; set; }
     
    public  DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cliente> Clientes { get; set; }

        public DbSet<TipoCliente> TipoClientes { get; set; }

    }
}
