// See https://aka.ms/new-console-template for more information
enum Color
{
    Purple = 1,
    Red,
    Green,
    Blue,
    White
}
class Program{
    static void Main()
    {
        Console.WriteLine("For which color do you want to the meaning");
        Console.WriteLine("1 Purple");
        Console.WriteLine("2 Red");
        Console.WriteLine("3 Green");
        Console.WriteLine("4 Blue");
        Console.WriteLine("5 White");

        Console.Write("Enter Your color  ");
        int code = int.Parse(Console.ReadLine());
        Color c = (Color)code;

        switch(c)
        {
            case Color.Purple:
            Console.WriteLine(c);
            break;

            case Color.Red:
            Console.WriteLine(c);
            break;

            case Color.Green:
            Console.WriteLine(c);
            break;

            case Color.Blue:
            Console.WriteLine(c);
            break;

            case Color.White:
            Console.WriteLine(c);
            break;
        }
    }
}