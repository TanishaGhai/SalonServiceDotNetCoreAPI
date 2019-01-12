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
        }
         public  void CreateConnection(string conn) {  
            _client= new MongoClient(_config.GetConfigurationValue("ConnectionString"));  
            _database=_client.GetDatabase(_config.GetConfigurationValue("DataBase"));
        }   


        

    }
}