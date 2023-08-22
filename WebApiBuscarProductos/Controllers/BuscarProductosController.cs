using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBuscarProductos.Application.Contracts;
using WebApiBuscarProductos.Application.Dto;

namespace WebApiBuscarProductos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuscarProductosController : ControllerBase
    {

        private readonly IBuscarProductosService _buscarProductosService;

        public BuscarProductosController(IBuscarProductosService buscarProductosService)
        {
            _buscarProductosService = buscarProductosService;   
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProoductosDto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _buscarProductosService.CreateAsync(producto);
            return Ok(producto.id);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var producto = await _buscarProductosService.GetByIdAsync(id);
            if (producto == null)
            {
                return NotFound();
            }   
            return Ok(producto);
        }
    }
}
