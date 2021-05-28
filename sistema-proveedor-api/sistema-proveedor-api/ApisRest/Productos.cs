using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sistema_proveedor_api.BOImpl;
using sistema_proveedor_api.DAO;
using sistema_proveedor_api.DTO;
using sistema_proveedor_api.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_proveedor_api.Controllers
{
    [ApiController]
    [Route("proveedor/[controller]")]
    public class Productos : ControllerBase
    {

        private TipoIdentificacionBOImpl objTipoIdentificacionBOImpl;

        public Productos(DbContextOptions<MyDBContext> options)
        {
            this.objTipoIdentificacionBOImpl = new TipoIdentificacionBOImpl(options);
        }


        [HttpGet("{id}")]
        public Object consultaId(int id)
        {
            try
            {

                return new Response200("ok",
                  this.objTipoIdentificacionBOImpl.consultarTipoIdentificacion(id));
            }
            catch (BOException e)
            {
                return new ResponseError(400, e.Message, e.Data);
            }
            catch (Exception e)
            {
                return new ResponseError(500, e.Message, e.Data);
            }
        }
    }
}
