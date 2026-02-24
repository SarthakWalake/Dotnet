namespace CsThreads
{
    class MainClass
    {
         
        public static void M()
        {
            for(int i = 0; i < 10; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine("Thread M:{0}", i);
            }
        }

        public static void N()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Another Thread: {0}", i);
            }
        }

        public static void P(object s)
        {
            Console.WriteLine("Hello " + (string)s);
        }

        static void Main()
        {
            //Thread t1 = new Thread(M);
            //Thread t2 = new Thread(N);

            //t1.IsBackground = true;
            //t1.Start();

            

            //Console.WriteLine("Checking whether T1 is Background Thread " + t1.IsBackground);
            //t2.Start();

            MyClass.MyMain();

        }
    }
}