using System;

enum Daysofweek
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thrusday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        Daysofweek day = Daysofweek.Monday;

        Console.WriteLine(day);
        Console.WriteLine((int)day);

        Console.Write("Enter your Day number: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine((Daysofweek)x);
    }
}
