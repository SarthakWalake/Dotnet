using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

class Employee
{
    private int _empId;
    private string _empName;
    private string _contact;

    private string _city;

    private int _salary;


    public Employee(int empId , string empName , string contact , string city , int salary)
    {
        _empId = empId;
        _empName = empName;
        _contact = contact;
        _city = city;
        _salary = salary;
    }

        public string City
        {
            get{return _city;}
            set{_city = value;}
        }
        public string Contact
        {
            get{return _contact;}
            set{_contact = value;}
        }

        public string Salary{get ; private set;}
    public void EmployeeDetails()
    {
        Console.WriteLine("Emp Id "+_empId);
        Console.WriteLine("Emp Name "+_empName);
        Console.WriteLine("Contact Number "+_contact);
        Console.WriteLine("City "+_city);
        Console.WriteLine("salary "+_salary);
    }
}