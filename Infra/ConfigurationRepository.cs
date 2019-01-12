using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace SalonServiceDotNetCoreAPI.Infra
{
    public interface IConfigutaionRepository
    {
        string GetConfigurationValue(string key);
    }

    public class ConfigurationRepository : IConfigutaionRepository
    {
         private IConfiguration _configuration;
        public ConfigurationRepository(IConfiguration config)
        {   
            _configuration=config;
        }
        public string GetConfigurationValue(string key)
        {
           return GetConfigurationValue(key) ?? _configuration.GetSection(key).Value;

        }
    }
}