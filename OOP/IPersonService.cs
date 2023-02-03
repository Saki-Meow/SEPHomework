using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IPersonService
    {
        int CalculateAge();
        decimal CalculateSalary();
        List<string> GetAddresses();
    }
}
