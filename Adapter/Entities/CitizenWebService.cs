using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class CitizenWebService
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char[] TcNumber { get; set; }
        public bool IsCriminal { get; set; }
        public int Age { get; set; }
    }
}
