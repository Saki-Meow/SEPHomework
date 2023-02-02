using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface ICourseService
    {
        void AddEnrolledStudent(Student student);
        List<Student> GetEnrolledStudents();
    }
}
