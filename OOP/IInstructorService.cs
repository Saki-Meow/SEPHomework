using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IInstructorService : IPersonService
    {
        void SetDepartment(Department department);
        decimal CalculateBonus();
        void SetHead(Department department);
        decimal CalculateExperience();
    }
}
