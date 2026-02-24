// See https://aka.ms/new-console-template for more information
namespace MethodHiding_Overriding
{
    class Class1
    {
        public virtual void S()
        {
            Console.WriteLine("Class 1 :: S");
        }

        public virtual void N()
        {
            Console.WriteLine("Class 1 :: N");
        } 
    }

    class Class2 : Class1
    {
        public new void S()             //Method Hiding
        {
            //base.S();
            Console.WriteLine("Class 2 :: S");
            
        }

        public override void N()        //Method Overriding
        {
           // base.N();
            Console.WriteLine("Class 2 :: N");
        }

        public void K()
        {
            Console.WriteLine("Class 2 :: K");
        }
    }

    class MainClass
    {
        static void Main()
        {
             Class1 c1 = new Class2();
             c1.S();
             c1.N();

            Console.WriteLine("-----------------------------------------");

        }
    }
}