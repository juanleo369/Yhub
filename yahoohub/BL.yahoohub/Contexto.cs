﻿using System;
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
   // Database.SetInitializer(new DatosdeInicio());
}

public DbSet<Producto> Productos { get; set; }
         
       }
}
