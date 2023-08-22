using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBuscarProductos.Application.Dto;

namespace WebApiBuscarProductos.Application.Contracts
{
    public interface IBuscarProductosService
    {

        Task<BuscarProductosDto> GetByIdAsync(string id);
        Task CreateAsync(ProoductosDto producto);
    }
}
