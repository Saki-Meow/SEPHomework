using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student : Person, IStudentService
    {
        private List<Course> courses;

        public Student()
        {
            courses = new List<Course>();
        }

        public void EnrollInCourse(Course course)
        {
            courses.Add(course);
            course.AddEnrolledStudent(this);
        }

        public decimal CalculateGPA()
        {
            // Implementation
        }
    }
}
