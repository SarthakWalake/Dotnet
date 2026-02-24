using System;
using PolymorphismAssigment;

class MainClass
{
    static void Main()
    {
        Employee[] emp = new Employee[10];
        int count = 0;
        int choice;

        do
        {
            Console.WriteLine("\n===== Employee Management System =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("3. Print All Employees");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (count >= 10)
                    {
                        Console.WriteLine("Employee array is full!");
                        break;
                    }

                    Console.WriteLine("\nSelect Employee Type:");
                    Console.WriteLine("1. Admin");
                    Console.WriteLine("2. HR");
                    Console.WriteLine("3. Software");
                    Console.Write("Enter type: ");
                    int type = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Basic Salary: ");
                    double salary = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter DA: ");
                    double da = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter HRA: ");
                    double hra = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Allowance: ");
                    double allowance = Convert.ToDouble(Console.ReadLine());

                    if (type == 1)
                    {
                        emp[count] = new Admin(name, salary, da, hra, allowance);
                    }
                    else if (type == 2)
                    {
                        emp[count] = new HR(name, salary, da, hra, allowance);
                    }
                    else if (type == 3)
                    {
                        emp[count] = new Software(name, salary, da, hra, allowance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid type!");
                        break;
                    }

                    count++;
                    Console.WriteLine("Employee added successfully!");
                    break;

                case 2:
                    break;

                case 3:
                    for (int i = 0; i < count; i++)
                    {
                        emp[i].DisplayDetails();   // polymorphism
                    }
                    break;

            }

        } while (choice != 4);
    }
}
