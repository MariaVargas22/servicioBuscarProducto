using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiBuscarProductos.Domain
{
    public class ProductoEntity:BaseEntity
    {
        public string? name { get; set; }   
        public string? descripcion { get; set; }
    }
}
