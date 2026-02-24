using System;

class Program
{
    static void Main()
    {
        // Input for calculator
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());

        Calculator(a, b);

        // Ascending order
        Ascending(a, b);

        // Table input
        Console.WriteLine("Enter start point:");
        int startPoint = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter end point:");
        int endPoint = int.Parse(Console.ReadLine());

        PrintTable(startPoint, endPoint);
    }

    // Calculator function
    static void Calculator(int a, int b)
    {
        Console.WriteLine("Choose the option");
        Console.WriteLine("1 : Addition");
        Console.WriteLine("2 : Subtraction");
        Console.WriteLine("3 : Multiplication");
        Console.WriteLine("4 : Division");

        int c = int.Parse(Console.ReadLine());

        switch (c)
        {
            case 1:
                Console.WriteLine("Result: " + (a + b));
                break;

            case 2:
                Console.WriteLine("Result: " + (a - b));
                break;

            case 3:
                Console.WriteLine("Result: " + (a * b));
                break;

            case 4:
                if (b != 0)
                    Console.WriteLine("Result: " + (a / b));
                else
                    Console.WriteLine("Error: Division by zero");
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }

    // Print table function
    static void PrintTable(int startPoint, int endPoint)
    {
        int i = startPoint;

        while (i <= endPoint)
        {
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine(i + " x " + j + " = " + (i * j));
                j++;
            }
            Console.WriteLine("-----------------------------");
            i++;
        }
    }

    // Ascending function
    static void Ascending(int a, int b)
    {
        if (a < b)
            Console.WriteLine("Ascending Order: " + a + " , " + b);
        else if (b < a)
            Console.WriteLine("Ascending Order: " + b + " , " + a);
        else
            Console.WriteLine("Both numbers are equal: " + a + " , " + b);
    }
}
