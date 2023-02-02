using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Person : IPersonService
    {
        private List<string> addresses;
        public decimal Salary { get; set; }

        protected Person()
        {
            addresses = new List<string>();
        }

        public int CalculateAge()
        {
            // Implementation
        }

        public decimal CalculateSalary()
        {
            // Implementation
        }

        public List<string> GetAddresses()
        {
            return addresses;
        }
    }
}
