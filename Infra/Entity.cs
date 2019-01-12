using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace SalonServiceDotNetCoreAPI.Infra
{
    public interface IEntity<TKey>
    {
        [BsonId]
        TKey Id { get; set; }
    }

    public interface IEntity : IEntity<string>
    {
    }
}