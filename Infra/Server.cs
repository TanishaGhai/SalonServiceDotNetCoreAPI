using System.Data;
using MongoDB.Driver;
using MongoDB.Bson;

 namespace SalonServiceDotNetCoreAPI.Infra
{
    public interface IServer
    {
        IMongoDatabase Database{get;}
        void CreateConnection(string conn);
    }
    public class MongoDbServer:IServer
    {
        IConfigutaionRepository _config;
        private IMongoDatabase _database;
        private MongoClient _client;  
        public IMongoDatabase Database
        {
            get
            {
                return _database;
            }
        }
        public MongoDbServer(IConfigutaionRepository config)
        {
            _config=config;
             _client= new MongoClient(_config.GetConnectionStringValue("ConnectionString"));  
            _database=_client.GetDatabase(_config.GetDatabaseName("DataBase"));
        }
         public  void CreateConnection(string conn) {  
           
        }   


        

    }
}