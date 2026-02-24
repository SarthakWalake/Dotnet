// See https://aka.ms/new-console-template for more information

class Class1
{
    static void N(ref int x)
    {
        x = 100;
        Console.WriteLine(x);
    }

    static void NS(out int x)
    {
        x = 200;
    }

    static void Main()
    {
        int i = 10;
        N(ref i);
        Console.WriteLine(i);

        int j = 20;
        NS(out j);

        Console.WriteLine(j);
    }
    
}

