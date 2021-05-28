using Microsoft.EntityFrameworkCore;
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
        private TiposIdentificacionDao context;

        public TipoIdentificacionBOImpl()

        {
    
        }

        public TipoIdentificacionBOImpl(TiposIdentificacionDao objTiposIdentificacionDao)

        {
            this.context = objTiposIdentificacionDao;
        }

        public TiposIdentificacion consultarTipoIdentificacion(int id)
        {

            List<TiposIdentificacion> studentsWithSameName = context.TiposIdentificacion.ToList();

            return null;
        }
    }
}
