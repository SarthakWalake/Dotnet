namespace Interface
{
    interface Interface1
    {
        void M();
    }

    interface Interface2 : Interface1
    {
        void M();
        void N();
    }

    class Class1 : Interface2
    {
        void Interface1.M()  // Explicit Implementation
        {
            Console.WriteLine("Interface 1 :: M");
        }

        public void M()  // Implicit Implementation
        {
            Console.WriteLine("Class 1 :: M");
        }

        void Interface2.N()
        {
            Console.WriteLine("Interface 2 :: N");
        }
    }
}