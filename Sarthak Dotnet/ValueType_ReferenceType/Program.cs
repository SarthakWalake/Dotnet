// See https://aka.ms/new-console-template for more information

struct Student
{
    public int Id;
}

class Employee
{
    public int Id;
}

class MainClass
{
    public static void  Main()
    {
        int[] arr = new int[3];

        foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("------------------");

        Student[] students = new Student[3];

        foreach(Student i in students)
        {
            Console.WriteLine(i.Id);
        }
        Console.WriteLine("---------------------");

        // We have Created an array object of type employee and size 3.
        // Array Constructor is called and initalize its cell with default value,
        // which is null since Employee is a reference type.
        // Employee object is still not created
        Employee[] employees = new Employee[3]; 

        foreach(Employee employee in employees)
        {
            Console.WriteLine(employee); // will print null object 3 times.
        }
    
        Console.WriteLine("--------------------");

        foreach(Employee employee in employees)
        {
            Console.WriteLine(employee.Id); // will throw null reference exception here since
                                            // object are still not created.
        }

        employees[0] = new Employee();
        employees[1] = new Employee();
        employees[2] = new Employee();


        foreach(Employee employee in employees)
        {
            Console.WriteLine(employee.Id); // will print 0 since employee object created 
                                    // with call of default constructor which will initalize.
        }
    }
}