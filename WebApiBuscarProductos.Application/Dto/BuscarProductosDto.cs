using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiBuscarProductos.Application.Dto
{
    public class BuscarProductosDto
    {

        public string? name { get; set; }
        public string? description { get; set; } 
        public bool? disponible { get; set; }
    }
}
