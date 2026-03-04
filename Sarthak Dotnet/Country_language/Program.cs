// See https://aka.ms/new-console-template for more information
using System;
enum language
{
    India = 1,
    Australia,
    US,
    UK,
    China,
    Japan,
    Canada,
    Brazil,
    Spain
}

class Program{
    public static void Main()
    {
        Console.WriteLine("1 India");
        Console.WriteLine("2 Australia");
        Console.WriteLine("3 US");
        Console.WriteLine("4 UK");
        Console.WriteLine("5 China");
        Console.WriteLine("6 Japan");
        Console.WriteLine("7 Canada");
        Console.WriteLine("8 Brazil");
        Console.WriteLine("9 Spain");

        Console.Write("Enter your choice  ");
        int c = int.Parse(Console.ReadLine());
        language l =(language)c;

        switch(l)
        {
        case language.India:
        goto case language.Australia;

        case language.Australia:
        goto case language.US;

        case language.US:
        goto case language.UK;

        case language.UK:
        Console.WriteLine("Language spoken in "+l+" is English");
        break;

        case language.China:
        Console.WriteLine("Language Spoken in "+l+" is Chinees");
        break;

        case language.Japan:
        Console.WriteLine("Language Spoken in "+l+" is Japanase");
        break;

        case language.Canada:
        Console.WriteLine("Language Spoken in "+l+" is Canada");
        break;

        case language.Brazil:
        Console.WriteLine("Language spoken in "+l+" is Brazilan");
        break;

        case language.Spain:
        Console.WriteLine("Language spoken in "+l+" is Spainch");
        break;

        }
    }
}