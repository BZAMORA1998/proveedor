using Microsoft.EntityFrameworkCore;
using sistema_proveedor_api.Dao;
using sistema_proveedor_api.DAO;
using sistema_proveedor_api.MODEL;


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
            return this.objTipoIdentificacionDao.find(id);
        }

        public void actualizacionTipoIdentificacion(int id, TiposIdentificacion obj)
        {
            TiposIdentificacion objTipoIdentificacion =this.objTipoIdentificacionDao.find(id);
            objTipoIdentificacion.esActivo=obj.esActivo;
            objTipoIdentificacion.nombre=obj.nombre;
            this.objTipoIdentificacionDao.update(objTipoIdentificacion);
        }

        internal void agregarTipoIdentificacion(TiposIdentificacion objTiposIdentificacion)
        {
            this.objTipoIdentificacionDao.add(objTiposIdentificacion);
        }

        internal void eliminarTipoIdentificacion(int id)
        {
            TiposIdentificacion objTipoIdentificacion = this.objTipoIdentificacionDao.find(id);
            this.objTipoIdentificacionDao.Remove(objTipoIdentificacion);
        }
    }
}
