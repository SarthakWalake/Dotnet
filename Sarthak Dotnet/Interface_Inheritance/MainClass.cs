

using Interface;

namespace Interface_Inheritance
{
    class MainClass
    {
        static void Main()
        {
            Interface1 i1;
            Interface2 i2;

            Class1 c1 = new Class1();
            i1 = i2 = c1;
            i1.M();
            i2.M();
            i2.N();
            c1.M();
        }
    }
}
