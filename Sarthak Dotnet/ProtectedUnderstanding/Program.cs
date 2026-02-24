// See https://aka.ms/new-console-template for more information
class Class1
{
    protected void f1()
    {
        Console.WriteLine("Class1 :: f1");
    }
}

class Class2 : Class1
{
    protected void f1()
    {
        Console.WriteLine("Class2 : : f1");
    }
    public void f2()
    {
        //Console.WriteLine("Class2 :: f2");
        f1();
        this.f1();
        base.f1();
    }
}

class MainClass
{
    static void Main()
    {
        Class2 cs = new Class2();
        cs.f2();
    }
}

