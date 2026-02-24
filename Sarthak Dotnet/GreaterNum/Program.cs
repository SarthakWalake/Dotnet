// See https://aka.ms/new-console-template for more information
int x , y ;
Console.Write("Enter the value of x  ");
x = int.Parse(Console.ReadLine());
Console.Write("Enter the value of y  ");
y = int.Parse(Console.ReadLine());

if(x > y)
{
Console.WriteLine(x+ " is Greater number than "+y);
}
 else
     {
        Console.WriteLine(y+ " is Greater number than "+x);
    }

