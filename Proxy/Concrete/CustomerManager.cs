using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Proxy.Abstract;
using Proxy.Entities;

namespace Proxy.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private List<Customer> customers;

        public CustomerManager()
        {
            customers = new List<Customer>
            {
                new Customer{Name = "Ali",Surname = "Yıldızöz",Address = "Diyarbakır",Email = "aliyildizoz909@gmail.com"},
                new Customer{Name = "Merve",Surname = "Çiçek",Address = "İstanbul",Email = "merveck@gmail.com"},
                new Customer{Name = "Burak",Surname = "Kaya",Address = "Ankara",Email = "burakkaya@gmail.com"},
                new Customer{Name = "Engin",Surname = "Yılmaz",Address = "İzmir",Email = "enginylz@gmail.com"}
            };
        }

        public List<Customer> GetAll()
        {
            Thread.Sleep(5000);
            return customers;
        }

        public Customer GetByName(string name)
        {
            return customers.FirstOrDefault(customer => customer.Name == name);
        }
    }
}
