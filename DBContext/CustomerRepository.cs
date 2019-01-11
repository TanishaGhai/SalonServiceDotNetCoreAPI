
using System;
using System.Collections.Generic;
using SalonServiceDotNetCoreAPI.Model;

namespace SalonServiceDotNetCoreAPI.DBContext{

public interface ICustomerRepository
{
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<Customer> GetCustomerByPhone();
        IEnumerable<Customer> GetCustomerByBDate();
        IEnumerable<Customer> GetCustomerByAniDate();
        int AddCustomer(string customerName,string PhoneNum,DateTime BDate, DateTime AniDate);
        bool DeleteCustomer(int customerId);
        bool UpdateCustomer(string customerName,string PhoneNum,DateTime BDate, DateTime AniDate);
}
    public class CustomerRepository: ICustomerRepository
    {
        ISlDbContext _slDbCntxt;
        public (ISlDbContext slDbCntxt)
        {
            this._slDbCntxt=slDbCntxt;
        }
        public IEnumerable<T> Get()
        {
           return _slDbCntxt.Set<T>();

        }
    }

}