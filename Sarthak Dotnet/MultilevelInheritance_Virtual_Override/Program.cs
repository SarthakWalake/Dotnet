namespace MutlilevelInheritance_Virtual_Override
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
        public virtual new void M()
        {
            Console.WriteLine("C");
        }
    }

    class D : C
    {
        public override void M()
        {
            Console.WriteLine("D");
        }
    }

    class MainClass
    {
        static void Main()
        {
            A a;  B b; C c; D d;
            a = b = c = d = new D();
            a.M();  b.M(); c.M(); d.M();
        }
    }
}