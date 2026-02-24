

namespace CsThreads
{
     class MyClass
    {
        static object obj = new object();

        static void M()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "Entered inside method m");

            lock(obj)
            {
                for(int i = 0; i< 100;i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                }
            }
        }

        public static void MyMain()
        {
            Thread t1 = new Thread(M); t1.Name = "First";
            Thread t2 = new Thread(M); t2.Name = "Second";

            t1.Start();
            t2.Start();

            for(int i = 0;i< 100;i++)
            {
                Console.WriteLine("Enter in Main code execution" + i);
            }
        }
    }
}
