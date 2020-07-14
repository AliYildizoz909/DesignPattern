using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Proxy.Entities;

namespace Proxy.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetByName(string name);
    }
}
