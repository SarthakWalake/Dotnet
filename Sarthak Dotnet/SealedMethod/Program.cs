namespace SealedMethod
{ 
    class A
    {
        public virtual void M()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public override void M()
        {
            Console.WriteLine("B");
        }
    }

    class C : B
    {
        public sealed override void M()         // Sealed Method will be inherited
                                                // but cannot be overriden further.
        {
            Console.WriteLine("C");
        }
    }

    sealed class D : C
    {
        public new void M()
        {
            Console.WriteLine("D");
        }

        public void P()
        {
            base.M();
            Console.WriteLine("D : P");
        }
    }

    // class E : D  { } Sealed class cannot be inherited

    class MainClass
    {
        static void Main()
        {
            B b;
            C c;
            D d;
            b = c = d = new D();
            b.M();
            Console.WriteLine("------------------------------------------");
            c.M();
            Console.WriteLine("-------------------------------------------");
            d.P();
        }
    }
}