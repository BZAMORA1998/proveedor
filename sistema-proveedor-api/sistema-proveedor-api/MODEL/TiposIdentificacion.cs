using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_proveedor_api.MODEL
{
    public class TiposIdentificacion
    {
        public int SECUENCIA_TIPO_IDENTIFICACION { get; set; }
        public string es_activo { get; set; }
        public string nombre { get; set; }
    }
}
