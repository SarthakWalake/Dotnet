using EmployeeDetails;
 
            Employee[] employees = new Employee[10]; // Array of size 10
            int count = 0;
            int choice;

            do
            {
                Console.WriteLine("\n===== Employee Salary System =====");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Print Employee Salary");
                Console.WriteLine("3. Print All Employees Salary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (count < 10)
                        {
                            Console.Write("Enter Employee Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Basic Salary: ");
                            double basic = Double.Parse(Console.ReadLine());

                            Console.Write("Enter HR Amount: ");
                            double hr = Double.Parse(Console.ReadLine());

                            Console.Write("Enter DA Amount: ");
                            double da = Double.Parse(Console.ReadLine());

                            Console.Write("Enter Software Allowance: ");
                            double software = Double.Parse(Console.ReadLine());

                            employees[count] = new SoftwareAllowance(name, basic, hr, da, software);
                            count++;

                            Console.WriteLine("Employee Added Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Employee array is full!");
                        }
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        for (int i = 0; i < count; i++)
                        {
                            employees[i].PrintSalaryDetails(); 
                        }
                        break;

                }

            } while (choice != 4);
