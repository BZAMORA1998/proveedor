using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sistema_proveedor_api.DAO;
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
        private MyDBContext myDbContext;

        public Productos(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<TiposIdentificacion> Get()
        {
            return (this.myDbContext.TiposIdentificacions.ToList());
        }
    }
}
