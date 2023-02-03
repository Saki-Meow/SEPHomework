using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Course : ICourseService
    {
        private List<Student> enrolledStudents;

        public Course()
        {
            enrolledStudents = new List<Student>();
        }

        public void AddEnrolledStudent(Student student)
        {
            enrolledStudents.Add(student);
        }

        public List<Student> GetEnrolledStudents()
        {
            return enrolledStudents;
        }
    }
}
