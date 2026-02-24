using System;
using StudentMarksheet;

class MainClass
{
    static void Main()
    {
        Student[] students = new Student[10];
        int count = 0;
        int choice;

        do
        {
            Console.WriteLine("\n===== Student Marksheet System =====");
            Console.WriteLine("1. Add Student Details");
            Console.WriteLine("2. Print Result by Roll No");
            Console.WriteLine("3. Print All Student Marksheet");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (count >= 10)
                    {
                        Console.WriteLine("Student array is full!");
                        break;
                    }

                    Console.Write("Enter Roll No: ");
                    int roll = int.Parse(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter English Marks: ");
                    int eng = int.Parse(Console.ReadLine());

                    Console.Write("Enter General Studies Marks: ");
                    int gs = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nSelect Stream:");
                    Console.WriteLine("1. Science");
                    Console.WriteLine("2. Commerce");
                    Console.WriteLine("3. Art");
                    Console.Write("Enter choice: ");
                    int stream = int.Parse(Console.ReadLine());

                    if (stream == 1)
                    {
                        Console.Write("Enter Physics Marks: ");
                        int phy = int.Parse(Console.ReadLine());

                        students[count] = new Science(roll, name, eng, gs, phy);
                    }
                    else if (stream == 2)
                    {
                        Console.Write("Enter Accounts Marks: ");
                        int acc = int.Parse(Console.ReadLine());

                        students[count] = new Commerce(roll, name, eng, gs, acc);
                    }
                    else if (stream == 3)
                    {
                        Console.Write("Enter History Marks: ");
                        int his = int.Parse(Console.ReadLine());

                        students[count] = new Art(roll, name, eng, gs, his);
                    }
                    else
                    {
                        Console.WriteLine("Invalid stream!");
                        break;
                    }

                    count++;
                    Console.WriteLine("Student added successfully!");
                    break;

                case 2:
                    Console.Write("Enter Roll No to search: ");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    bool found = false;

                    for (int i = 0; i < count; i++)
                    {
                        if (students[i] != null && students[i].GetRollNo() == r)
                        {
                            students[i].PrintResult();
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        Console.WriteLine("Student not found!");

                    break;

                case 3:
                    Console.WriteLine("\n===== All Student Marksheet =====");
                    for (int i = 0; i < count; i++)
                    {
                        if (students[i] != null)
                        {
                            students[i].PrintResult(); // polymorphism
                            Console.WriteLine("----------------------");
                        }
                    }
                    break;

            }

        } while (choice != 4);
    }
}
