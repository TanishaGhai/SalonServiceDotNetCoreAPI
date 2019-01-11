using System;

namespace SalonAPI.Model
{
    public class Customer
    {
        public int CustomerId{get;set;}
        public string CustomerName{get;set;}
        public DateTime  CustomerBDay{get;set;}
        public DateTime CustomerAni{get;set;}
        public string CustomerPhone{get;set;}
    }
}