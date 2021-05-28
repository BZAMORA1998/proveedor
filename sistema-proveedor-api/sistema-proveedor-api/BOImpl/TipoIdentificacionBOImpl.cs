using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_proveedor_api.Dao;
using sistema_proveedor_api.DAO;
using sistema_proveedor_api.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_proveedor_api.BOImpl
{
    public class TipoIdentificacionBOImpl
    {
        private TipoIdentificacionDao objTipoIdentificacionDao;

        public TipoIdentificacionBOImpl(DbContextOptions<MyDBContext> options)

        {
            this.objTipoIdentificacionDao = new TipoIdentificacionDao(options);
        }

        public TiposIdentificacion consultarTipoIdentificacion(int id)
        {
            return this.objTipoIdentificacionDao.consultarTipoIdentificacion(id);
        }
    }
}
