// See https://aka.ms/new-console-template for more information
using System;

class Employee
{
    // private data members
    private static int nextEmpid = 100;
    private int empId;
    private string empName;
    private double salary;

    // constructor with arguments: name and salary
    public Employee(string name, double salary)
    {
        nextEmpid++;
        this.empId = nextEmpid;
        this.empName = name;
        this.salary = salary;
    }

    // print function
    public void PrintEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + empId);
        Console.WriteLine("Employee Name: " + empName);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("-------------------------");
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee("Sarthak", 50000);
        Employee emp2 = new Employee("Nayan", 60000);
        Employee emp3 = new Employee("Vinu", 40000);

        emp1.PrintEmployeeDetails();
        emp2.PrintEmployeeDetails();
        emp3.PrintEmployeeDetails();

    }
}

