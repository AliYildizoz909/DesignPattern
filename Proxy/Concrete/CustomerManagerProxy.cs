using System;
using System.Collections.Generic;
using System.Text;
using Proxy.Abstract;
using Proxy.Entities;

namespace Proxy.Concrete
{
    public class CustomerManagerProxy : ICustomerService
    {
        private CustomerManager customerManager = null;

        public CustomerManagerProxy()
        {
            customerManager = new CustomerManager();
        }
        public List<Customer> GetAll()
        {
            Console.WriteLine("Yükleniyor...");
            List<Customer> customers= customerManager.GetAll();
            Console.Clear();
            return customers;
        }

        public Customer GetByName(string name)
        {
            return customerManager.GetByName(name);
        }
    }
}
