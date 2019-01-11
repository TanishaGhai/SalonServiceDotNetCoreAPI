using System;

namespace SalonServiceDotNetCoreAPI.Model
{
    public class Product
    {
        public int ProductId{get;set;}
        public string ProductName{get;set;}
        public DateTime  ProductSGST{get;set;}
        public DateTime ProductCGST{get;set;}
    
    }
}