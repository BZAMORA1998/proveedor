using Microsoft.EntityFrameworkCore;
using sistema_proveedor_api.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_proveedor_api.DAO
{
    public class MyDBContext : DbContext
    {
        public DbSet<TiposIdentificacion> TiposIdentificacions { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map entities to tables  
            modelBuilder.Entity<TiposIdentificacion>().ToTable("tbl_tipos_identificacion");

            // Configure Primary Keys  
            modelBuilder.Entity<TiposIdentificacion>().HasKey(ug => ug.SECUENCIA_TIPO_IDENTIFICACION).HasName("SECUENCIA_TIPO_IDENTIFICACION");

        }
    }
}
