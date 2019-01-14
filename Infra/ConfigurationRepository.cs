using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace SalonServiceDotNetCoreAPI.Infra
{
    public interface IConfigutaionRepository
    {
        string GetConnectionStringValue(string key);
        string GetDatabaseName(string key);
    }

    public class ConfigurationRepository : IConfigutaionRepository
    {
         private IConfiguration _configuration;

        public ConfigurationRepository(IConfiguration config)
        {   
            _configuration=config;
        }
        public string GetConnectionStringValue(string key)
        {
           return _configuration.GetSection("MongoDbConn").GetSection("ConnectionString").Value;
        }

         public string GetDatabaseName(string key)
        {
           return _configuration.GetSection("MongoDbConn").GetSection("DataBase").Value;
        }
    }
}