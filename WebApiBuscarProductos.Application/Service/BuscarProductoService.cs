using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBuscarProductos.Application.Contracts;
using WebApiBuscarProductos.Application.Dto;
using WebApiBuscarProductos.Domain;

namespace WebApiBuscarProductos.Application.Service
{
    public class BuscarProductoService : IBuscarProductosService
    {

        private readonly IBuscarRepository _buscarProductosService;
        private readonly IMapper _mapper;

        public BuscarProductoService(IBuscarRepository buscarProductosService, IMapper mapper)
        {
             _buscarProductosService = buscarProductosService;
            _mapper = mapper;
        }


        public async Task<BuscarProductosDto> GetByIdAsync(string id)
        {

            var producto = await _buscarProductosService.GetByIdAsync(id);

            return _mapper.Map<BuscarProductosDto>(producto);
        }

        public async Task CreateAsync(ProoductosDto producto)
        {
            var crearProducto= _mapper.Map<ProductoEntity>(producto);

            await _buscarProductosService.CreateAsync(crearProducto);
        }
    }
}
