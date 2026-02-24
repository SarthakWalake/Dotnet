// See https://aka.ms/new-console-template for more information
// Value type and Reference type
// class Class1
// {
//     public int x;
// }
// class MainClass
// {
//     static void Main()
//     {
//         int x = 10, y =20;
//         x = y;
//         y = 30;
//         Console.WriteLine(x+"\t"+y);

//         Class1 c1 = new Class1();
//         Class1 c2 = new Class1();

//         c1 = c2;
//         c2.x = 30;
//         Console.WriteLine(c1.x+"\t"+c2.x);
//     }
// }

// static member and static function
class Class1{
    int x =10;
    static int y = 20;

    static void f1()
    {
        y = 200;
    }

    void f2()
    {
        y = 100 // Accessing static member inside the non static function
    }
    static void Main()
    {
        Class1 m1 , m2;
        m1 = m2 = new Class1();

        m1.f2();
        Console.WriteLine(y);
        f1();
        Console.WriteLine(y);
    }
}