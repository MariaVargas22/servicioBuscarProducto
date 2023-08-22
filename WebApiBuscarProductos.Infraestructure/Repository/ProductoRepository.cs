using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBuscarProductos.Application;
using WebApiBuscarProductos.Domain;
using WebApiBuscarProductos.Infraestructure.Configuration;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace WebApiBuscarProductos.Infraestructure.Repository
{
    public class ProductoRepository : IBuscarRepository
    {

        private readonly DataBaseConfiguration _settings;
        private readonly IMongoCollection<ProductoEntity> _Producto;


        public ProductoRepository(IOptions<DataBaseConfiguration> settings)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.DatabaseName);
            _Producto = database.GetCollection<ProductoEntity>(_settings.ProductoCollection);
        }

        public async Task<ProductoEntity> GetByIdAsync(string id)
        {
            return await _Producto.Find<ProductoEntity>(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(ProductoEntity producto)
        {
            await _Producto.InsertOneAsync(producto);
        }
    }
}
