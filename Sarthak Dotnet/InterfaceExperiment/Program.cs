namespace InterfaceExperiment
{
    interface IGreeting
    {
        void Greet();
    }

    class Greeting
    {
        public static void GreetMe(IGreeting g)
        {
            g.Greet();
        }
    }

    class Japan : IGreeting
    {
        public static void Morning()
        {
            Console.WriteLine("Good Morning");
        }
        public void Greet()
        {
            Morning();
        }
    }

    class India : IGreeting
    {
        public static void Namsate()
        {
            Console.WriteLine("Namsate");
        }
        public void Greet()
        {
            Namsate();
        }
    }

    class America : IGreeting
    {
        public static void Wish()
        {
            Console.WriteLine("Hey");
        }
        public void Greet()
        {
            Wish();
        }
    }

    class MainClass
    {
        static void Main()
        {
            Greeting.GreetMe(new Japan());
            Greeting.GreetMe(new India());
            Greeting.GreetMe(new America());
        }
    }
}