namespace ConstructorExecutionSequence
{
    public class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine("Inside Base class with 0 parameter");
        }

        public MyBaseClass(int i)
        {
            Console.WriteLine("Inside Base class with 1 parameter:{0}", i);
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass()
        {
            Console.WriteLine("Inside Derived class with 0 parameter");
        }

        public MyDerivedClass(int i) : this(i , 9)
        {
            Console.WriteLine("Inside Derived class with 1 parameter :{0}",i);
        }

        public MyDerivedClass(int i , int j) : base(j)
        {
            Console.WriteLine("inside Derived class with 2 parameter :{0},{1}",i,j);
        }
    }

    class MainClass()
    {
        static void Main()
        {
            MyDerivedClass obj = new MyDerivedClass();
            Console.WriteLine("-------------------------------");

            MyDerivedClass obj1 = new MyDerivedClass(4);
            Console.WriteLine("---------------------------------");

            MyDerivedClass obj2 = new MyDerivedClass(4,8);
        }
    }
}