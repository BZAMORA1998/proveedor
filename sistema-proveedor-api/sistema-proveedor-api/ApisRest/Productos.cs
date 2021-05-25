using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        private readonly ILogger<Productos> _logger;
        public Productos(ILogger<Productos> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            return "HOLA MUNDO";
        }
    }
}
