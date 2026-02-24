namespace IComparable_Employee
{
    class Employee : IComparable
    {
        private int ID;
        private string Name;
        private double Salary;
        public Employee(int id , string name , double salary)
        {
            this.ID = id;
            this.Name = name;
            this.Salary = salary;
        }

        public int CompareTo(object obj)
        {
            Employee emp = (Employee)obj;
            return this.ID.CompareTo(emp.ID);
        }

        public override string ToString()
        {
            return "ID: " + ID + " Name: " + Name + " Salary: " + Salary;
        }
    }

    class MainClass
    {
        static void Main()
        {
            int[] intArray = { 4, 1, 8, 3, 7, 2, 6, 5 };
            Array.Sort(intArray);

            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------");

            Employee[] empArray = new Employee[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nEnter details for Employee " + (i + 1));

                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Salary: ");
                double salary = double.Parse(Console.ReadLine());

                empArray[i] = new Employee(id, name, salary);
            }

            Array.Reverse(empArray);
            foreach(Employee emp in empArray)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("--------------------------");
            
            Array.Sort(empArray);

            foreach (Employee emp in empArray)
            {
                Console.WriteLine(emp);
            }
        }
    }
}