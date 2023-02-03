using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Department : IDepartmentService
    {
        public Instructor Head { get; set; }
        public decimal Budget { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        private List<Course> courses;

        public Department()
        {
            courses = new List<Course>();
        }

        public void SetBudget(decimal budget, DateTime start, DateTime end)
        {
            Budget = budget;
            Start = start;
            End = end;
        }

        public List<Course> GetCourses()
        {
            return courses;
        }
    }
}
