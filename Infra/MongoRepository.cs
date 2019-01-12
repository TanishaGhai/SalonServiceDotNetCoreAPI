using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SalonServiceDotNetCoreAPI.Infra
{

    public interface IMongoRepository<TEntity, TIdentifier>
     : IQueryable<TEntity> where TEntity : IEntity<TIdentifier>
    {
       TEntity GetById(TIdentifier id);
       IEnumerable<TEntity> GetAll();

    }
     public interface IMongoRepository<TEntity> : IQueryable<TEntity>, 
     IMongoRepository<TEntity, string>
        where TEntity : IEntity<string> { }

    public class MongoRepository<TEntity, TIdentifier> : 
    IQueryable<TEntity> where TEntity : IEntity<TIdentifier>
    {
        IServer _server;
        IMongoCollection<TEntity> _mongoCol;

        public Type ElementType =>  this._mongoCol.AsQueryable<TEntity>().ElementType;

        public Expression Expression => this._mongoCol.AsQueryable<TEntity>().Expression;

        public IQueryProvider Provider => this._mongoCol.AsQueryable<TEntity>().Provider;

        public MongoRepository(IServer server)
        {
            _server=server;
            _mongoCol=_server.Database.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public TEntity GetById(TIdentifier id)
        {
            return (this._mongoCol).Find(x => x.Id.Equals(id)).FirstOrDefaultAsync().Result;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _mongoCol.Find(new BsonDocument()).ToListAsync().Result;
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
             return this._mongoCol.AsQueryable<TEntity>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._mongoCol.AsQueryable<TEntity>().GetEnumerator();
        }
    }

      public class MongoRepository<TEntity> : MongoRepository<TEntity, string>, 
      IMongoRepository<TEntity>
        where TEntity : IEntity<string>
    {
        public MongoRepository(IServer server)
            : base(server) { }
    }

}