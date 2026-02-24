namespace AnonymouseMethod
{
    delegate void del(string s);

    class MainClass
    {
        public static void M(string name)
        {
            Console.WriteLine("My name is " + name);
        }

        static void Main()
        {
            del d = delegate (string s)
            {
                Console.WriteLine("Your name is " + s);
            };
            d += M;
            d("Sarthak");
        }
    }
}