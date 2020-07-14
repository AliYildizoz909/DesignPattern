using System;
using System.Collections.Generic;
using Proxy.Abstract;
using Proxy.Concrete;
using Proxy.Entities;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerService service = new CustomerManagerProxy();
            List<Customer> customers = service.GetAll();

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Name} - {customer.Surname} - {customer.Address} - {customer.Email}");
            }

            Console.ReadLine();
        }
    }
}
