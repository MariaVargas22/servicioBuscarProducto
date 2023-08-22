using WebApiBuscarProductos.Application;
using WebApiBuscarProductos.Application.Contracts;
using WebApiBuscarProductos.Application.Service;
using WebApiBuscarProductos.Infraestructure.Repository;

namespace WebApiBuscarProductos
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterMongoDependencies(this IServiceCollection services)
        {
           
            services.AddScoped<IBuscarProductosService, BuscarProductoService>();
            services.AddScoped<IBuscarRepository, ProductoRepository>();
 
        }
    }
}
