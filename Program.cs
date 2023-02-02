public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    void AddAddress(string address);
    string[] GetAddresses();
}

public interface IStudentService : IPersonService
{
    void EnrollInCourse(string courseName);
    void SetGrade(string courseName, char grade);
    decimal CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    void SetDepartment(string departmentName);
    void SetExperience(int years);
    decimal CalculateBonus();
}

public interface IDepartmentService
{
    void SetHead(string instructorName);
    string GetHead();
    void SetBudget(decimal budget, DateTime start, DateTime end);
    decimal GetBudget();
    void OfferCourse(string courseName);
    string[] GetCourses();
}

public abstract class Person : IPersonService
{
    private decimal _salary;
    private List<string> _addresses = new List<string>();

    public int CalculateAge()
    {
        // Implementation for calculating the age based on the birth date
    }

    public decimal CalculateSalary()
    {
        return _salary < 0 ? 0 : _salary;
    }

    public void AddAddress(string address)
    {
        _addresses.Add(address);
    }

    public string[] GetAddresses()
    {
        return _addresses.ToArray();
    }
}

public class Student : Person, IStudentService
{
    private Dictionary<string, char> _courses = new Dictionary<string, char>();

    public void EnrollInCourse(string courseName)
    {
        _courses[courseName] = 'A';
    }

    public void SetGrade(string courseName, char grade)
    {
        if (_courses.ContainsKey(courseName))
        {
            _courses[courseName] = grade;
        }
    }

    public decimal CalculateGPA()
    {
        // Implementation for calculating the GPA based on the grades of the courses
    }
}

public class Instructor : Person, IInstructorService
{
    private string _department;
    private int _experience;

    public void SetDepartment(string departmentName)
    {
        _department = departmentName;
    }

    public void SetExperience(int years)
    {
        _experience = years;
    }

    public decimal CalculateBonus()
    {
        // Implementation for calculating the bonus salary based on the years of experience
    }
}

public class Department : IDepartmentService
{
    private string _head;
    private decimal _budget;
    private DateTime _start;
    private DateTime _end;
    private List<string> _courses = new List<string>();

    public void SetHead(string instructorName)
    {
        _head = instructorName;
    }

    public string GetHead()
    {
        return _head;
    }

    public void SetBudget(decimal budget, DateTime start, DateTime end)
    {
        _budget = budget;
        _start = start
