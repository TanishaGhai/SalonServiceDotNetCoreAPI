using SalonServiceDotNetCoreAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace SalonServiceDotNetCoreAPI.DbContext
{
    public class SrDbCOntext : DbContext
    {
        public DbSet<Customer> Students { get; set; }
        public DbSet<Product> Books { get; set; }

    }
}