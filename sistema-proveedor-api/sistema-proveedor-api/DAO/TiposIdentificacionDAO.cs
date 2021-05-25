using Microsoft.EntityFrameworkCore;
using sistema_proveedor_api.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_proveedor_api.DAO
{
    public class TiposIdentificacionDAO : DbContext
    {
        public DbSet<TiposIdentificacion> TiposIdentificacions { get; set; }

        public TiposIdentificacionDAO(DbContextOptions<TiposIdentificacionDAO> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to configure  

            // Map entities to tables  
            modelBuilder.Entity<TiposIdentificacion>().ToTable("UserGroups");

            // Configure Primary Keys  
            modelBuilder.Entity<TiposIdentificacion>()
                .HasKey(u => u.SECUENCIA_TIPO_IDENTIFICACION).HasName("SECUENCIA_TIPO_IDENTIFICACION");

        }
    }
}
