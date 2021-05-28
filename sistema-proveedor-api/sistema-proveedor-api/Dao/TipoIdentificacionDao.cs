using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_proveedor_api.DAO;
using sistema_proveedor_api.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_proveedor_api.Dao
{
    public class TipoIdentificacionDao
    {
        private MyDBContext context;

        public TipoIdentificacionDao(DbContextOptions<MyDBContext> options)

        {
            this.context = new MyDBContext(options);
        }

        public TiposIdentificacion consultarTipoIdentificacion(int id)
        {
            return this.context.TiposIdentificacion.Find(id); ;
        }
    }
}
