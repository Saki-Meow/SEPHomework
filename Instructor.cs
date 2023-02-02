using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Instructor : Person, IInstructorService
    {
        private Department department;
        private DateTime joinDate;

        public Instructor()
        {
            department = null;
        }

        public void setHead(Department department)
        {
            department.Head = this;
        }

        public void setDepartment(Department department)
        {
            this.department = department;
        }

        public decimal CalculateExperience()
        {
            // Implementation
        }

        public decimal CalculateBonus()
        {
            // Implementation
        }
    }
}
