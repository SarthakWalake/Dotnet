// See https://aka.ms/new-console-template for more information
int a , b ;
Console.WriteLine("Welcome Sarthak to Calucator....");

Console.WriteLine("Enter the first number....");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Second number.....");
b = int.Parse(Console.ReadLine());

Console.WriteLine("1 : Addition");
Console.WriteLine("2 : Subtraction");
Console.WriteLine("3 : Multipication");
Console.WriteLine("4 : Division");

Console.WriteLine("Choose the option");
int c = int.Parse(Console.ReadLine());

switch(c)
{
     case 1:
        Console.WriteLine("Result: "+(a + b));
        break;

    case 2:
        Console.WriteLine("Result: "+(a - b));
        break;

    case 3:
        Console.WriteLine("Result: "+(a * b));
        break;

    case 4:
        if (b != 0)
            Console.WriteLine("Result: "+(a / b));
        else
            Console.WriteLine("Error: Division by zero");
        break;

    default:
        Console.WriteLine("Invalid operator");
        break;
}
