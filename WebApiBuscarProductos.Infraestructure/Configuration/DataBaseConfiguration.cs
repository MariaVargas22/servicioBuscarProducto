using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiBuscarProductos.Infraestructure.Configuration
{
    public class DataBaseConfiguration
    {

        public string? ProductoCollection { get; set; }
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
    }
}
