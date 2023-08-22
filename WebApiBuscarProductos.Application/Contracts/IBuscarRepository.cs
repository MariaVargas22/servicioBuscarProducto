using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBuscarProductos.Domain;

namespace WebApiBuscarProductos.Application
{
    public interface IBuscarRepository
    {

        Task<ProductoEntity> GetByIdAsync(string id);

        Task CreateAsync(ProductoEntity producto);


    }
}
