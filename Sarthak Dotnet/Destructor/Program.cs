using Destructor;

class MainClass
{
    static void Main()
    {
        for(int i = 0 ;i < 100;i++)
        {
            if(i % 10 == 0)
            {
                Console.WriteLine("-----------------------------");
                GC.Collect();
            }
            Employee obj = new MyEmployee(i + 101);
        }
        Console.WriteLine("*********************************");
    }
}