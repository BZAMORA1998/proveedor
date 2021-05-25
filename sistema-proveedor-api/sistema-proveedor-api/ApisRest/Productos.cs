using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public List<TiposIdentificacion> Get()
        {
            List<TiposIdentificacion> a =
                this.myDbContext.TiposIdentificacions
                .FromSqlRaw("SELECT * from tbl_tipos_identificacion").ToList();

            Console.WriteLine("Hola");
            for (int i=0;i<a.Count();i++)
            {
                Console.WriteLine(a[i].nombre);
            }

            return a;
            //return this.myDbContext.TiposIdentificacions.FromSql("Select * from Students where FirstName ='Bill'");
            //return (this.myDbContext.TiposIdentificacions.ToList());
        }
    }
}
