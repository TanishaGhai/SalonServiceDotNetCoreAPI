﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalonServiceDotNetCoreAPI.Model;
using SalonServiceDotNetCoreAPI.DBContext;

namespace SalonServiceDotNetCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerRepository _customerRepository;

        CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository=customerRepository;
        }

        // GET api/values
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Customer>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Route("Customers")]
        public ActionResult<IEnumerable<string>> GetAllCustomers()
        {
            return Ok(_customerRepository.GetAllCustomers());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}