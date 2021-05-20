using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_productos_api.Controllers
{
    [ApiController]
    [Route("/proveedor/[controller]")]
    public class Productos : ControllerBase
    {
       
        [HttpGet]   
        public ActionResult<String> Get()
        {
            return "Hola Mundo";
        }
    }
}
