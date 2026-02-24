namespace Destructor
{
    class Employee
    {
        public int Id;
        public Employee(int id)
        {
            this.Id = id;
            Console.WriteLine("Constructor for ID {0}",this.Id);
        }

        ~Employee()
        {
            Console.WriteLine("Destructor for Employee {0}",this.Id);
        }
    }

    class MyEmployee : Employee
    {
        public MyEmployee(int id) : base(id){}
        ~MyEmployee()
        {
              Console.WriteLine("Destructor for MyEmployee {0}",this.Id);
        }
    }
}