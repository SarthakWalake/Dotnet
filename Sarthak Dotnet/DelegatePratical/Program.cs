namespace DelegatePratical
{
    delegate void GreetingDelegate();
    class Greeting
    {
        public static void GreetMe(GreetingDelegate g)
        {
            g();
        }
    }

    class Japan 
    {
        public static void Morning()
        {
            Console.WriteLine("Good Morning");
        }
    }

    class India 
    {
        public static void Namsate()
        {
            Console.WriteLine("Namsate");
        }
    }

    class America 
    {
        public static void Wish()
        {
            Console.WriteLine("Hey");
        }
 
    }

    class MainClass
    {
        static void Main()
        {
            GreetingDelegate g1 = new GreetingDelegate(Japan.Morning);
            g1 += new GreetingDelegate(India.Namsate);
            g1 += new GreetingDelegate(America.Wish);

            Greeting.GreetMe(g1);
        }
    }
}