namespace Params
{
    class MainClass
    {
        static void M(int i , string s , params byte[] j)
        {
            foreach(byte b in j)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            byte[] b = { 1, 2, 3, 4, 5 };
            M(10, "hello", b);
            M(20, "Sarthak", 10, 20);
            M(30, "Walake");
        }
    }
}
