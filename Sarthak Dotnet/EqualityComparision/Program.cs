namespace EqualityComparision
{
    class Class1
    {
        public int x;
    }

    struct Student
    {
        public int x , y;
    }

    class MainClass
    {
        static void Main()
        {
            int i = 10; int j = 10;

            Console.WriteLine(i.Equals(j));
            Console.WriteLine(object.Equals(i , j));
            Console.WriteLine(i == j);
            Console.WriteLine("------------------------------");

            Class1 c1 = new Class1();
            c1.x = 10;
            Class1 c2 = new Class1();
            c1.x = 10;

            // Equal method checks for value equality if value type is compared and it checks for references equaltiy
            // reference type is compared

            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(object.Equals(c1,c2));
            Console.WriteLine(c1 == c2);
            Console.WriteLine(object.ReferenceEquals(c1,c2));
            Console.WriteLine("------------------------------");

            Console.WriteLine(c1.x.Equals(c2.x));
            Console.WriteLine(object.Equals(c1.x,c2.x));
            Console.WriteLine(c1.x == c2.x);
            Console.WriteLine("--------------------------------");
            Student s1 , s2;
            s1.x = 10;
            s1.y = 20;
            s2.x = 10;
            s2.y = 20;

            Console.WriteLine(object.Equals(s1,s2));
            Console.WriteLine(object.ReferenceEquals(s1,s2));
            Console.WriteLine("--------------------------");

            int x = 10;
            byte b = 10;
            Console.WriteLine(object.Equals(x,b));
            Console.WriteLine(x == b);
        }
    }
}