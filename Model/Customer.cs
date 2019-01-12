using System;
using SalonServiceDotNetCoreAPI.Infra;

namespace SalonServiceDotNetCoreAPI.Model
{
    public class Customer : IEntity
    {
        public string Id{get;set;}
        public string CustomerName{get;set;}
        public DateTime  CustomerBDay{get;set;}
        public DateTime CustomerAni{get;set;}
        public string CustomerPhone{get;set;}
    }
}