using System;
using SalonServiceDotNetCoreAPI.Infra;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SalonServiceDotNetCoreAPI.Model
{
    public class Customer : IEntity
    {

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id{get;set;}
        public string CustomerName{get;set;}
        public DateTime  CustomerBDay{get;set;}
        public DateTime CustomerAni{get;set;}
        public string CustomerPhone{get;set;}
    }
}