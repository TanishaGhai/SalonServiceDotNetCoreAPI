
using System;
using System.Collections.Generic;
using SalonServiceDotNetCoreAPI.Model;
using MongoDB.Driver;
using SalonServiceDotNetCoreAPI.Infra;

namespace SalonServiceDotNetCoreAPI.DBContext
{

    public interface ICustomerRepository
{
       IEnumerable<Customer> GetAllCustomers();
       // IEnumerable<Customer> GetCustomerByPhone();
        //IEnumerable<Customer> GetCustomerByBDate();  
        //IEnumerable<Customer> GetCustomerByAniDate();
        //int AddCustomer(string customerName,string PhoneNum,DateTime BDate, DateTime AniDate);
        //bool DeleteCustomer(int customerId);
        //bool UpdateCustomer(string customerName,string PhoneNum,DateTime BDate, DateTime AniDate);

}    
public class CustomerRepository: ICustomerRepository
    {
        IMongoRepository<Customer> _mongoRep;
        public CustomerRepository(IMongoRepository<Customer> mongoRep)
        {
           _mongoRep=mongoRep;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
              return _mongoRep.GetAll();
        }
    }

} 