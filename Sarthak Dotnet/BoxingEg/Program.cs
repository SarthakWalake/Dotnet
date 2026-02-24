namespace BoxingEg
{
    public interface IEmployee
    {
        int Salary { get; }
        void GiveRaise(int amount);
    }

    public struct Clerk : IEmployee
    {
        private int salary;
        public Clerk(int increment)
        {
            this.salary = increment;
        }
        public int Salary
        {
            get
            {
                return salary;
            }
        }

        public void GiveRaise(int amount)
        {
            salary += amount;
        }
    }

    class MainClass
    {
        static void Main()
        {
            Clerk c = new Clerk(1000);
            IEmployee e = c;  //Boxing 
            //((IEmployee)c).GiveRaise(50);
            e.GiveRaise(50);
            Console.WriteLine(c.Salary);
            Console.WriteLine(e.Salary);
        }
    }
}