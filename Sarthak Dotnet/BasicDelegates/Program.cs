

delegate void greetingDelegate();   // Delegate Definition

class MyClass
{
    public static void M()
    {
        Console.WriteLine("MyClass :: M");
    }
}

class Caller
{
    public static void Call(greetingDelegate greet)
    {
        greet();
    }
}

class MainClass
{
    static void sayHello()
    {
        Console.WriteLine("Hello");
    }
    static void Main()
    {
        greetingDelegate greeting = new greetingDelegate(sayHello);     // Delegate Instatiation.
        greeting += new greetingDelegate(MyClass.M);
        greeting();     // Delegate Call
        Caller.Call(greeting);
    }
}