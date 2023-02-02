using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IDepartmentService
    {
        void SetBudget(decimal budget, DateTime start, DateTime end);
        List<string> GetCourses();
    }
}
