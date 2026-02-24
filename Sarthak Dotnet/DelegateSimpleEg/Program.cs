 namespace DelegatesSimpleEg
{
    delegate void dele();       //Decleration Delegate

    class MainClass()
    {
        public static void M()
        {
            Console.WriteLine("M");
        }

        public static void N()
        {
            Console.WriteLine("N");
        }

        public static void Main()
        {
            dele d = new dele(M);       // Instantiating
            d += new dele(N);           // Assiging method N in invocation  list of delegate.

            d();        // Calling

            Console.WriteLine("---------------------");

            Delegate[] dArray = d.GetInvocationList();

            foreach(dele dl in dArray)
            {
                Console.WriteLine(dl.Method);
                Console.WriteLine(dl.Method.ReturnType);
                dl.DynamicInvoke();
                Console.WriteLine("---------------------");
            }
        }
    }
}