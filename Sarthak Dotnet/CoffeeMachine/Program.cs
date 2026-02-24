// See https://aka.ms/new-console-template for more information
int cost = 0 ;
Console.WriteLine("1 Small Coffee");
Console.WriteLine("2 Medium Coffee");
Console.WriteLine("3 Large Coffee");

Console.WriteLine("Choose the coffee size");
int Choose = int.Parse(Console.ReadLine());


switch(Choose)
{
    case 1:
    cost = cost + 25;
    Console.WriteLine("The Cost for small Coffee is  "+cost);
    break;

    case 2:
    cost = cost + 15;
    Console.WriteLine("The Cost for Medium Coffee is  "+cost);
    goto case 1;

    case 3:
    cost = cost + 10;
    Console.WriteLine("The Cost for Large Coffee is  "+cost);
    goto case 2;
    
    default:
    Console.WriteLine("Invalid operator");
    break;
    
}
