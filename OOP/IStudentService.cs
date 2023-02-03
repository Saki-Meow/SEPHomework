using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IStudentService : IPersonService
    {
        void EnrollInCourse(Course course);
        decimal CalculateGPA();
    }

}
