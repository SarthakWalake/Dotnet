
class MainClass
{
    public static void Swap<T>(T a,T b)
    {
        T temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After Swap A={0},B={1}",a,b);
    }
    static void Main()
    {
        
    }
}