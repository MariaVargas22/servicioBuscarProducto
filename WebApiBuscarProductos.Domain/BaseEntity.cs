using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace WebApiBuscarProductos.Domain
{
    public class BaseEntity
    {
        [BsonId]
        public string? Id { get; set; }

        public bool? disponible { get; set; }
    }
}
