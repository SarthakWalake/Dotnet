// See https://aka.ms/new-console-template for more information
int startPoint , endPoint , j;
Console.Write("Enter the startPoint = ");
startPoint = int.Parse(Console.ReadLine());

Console.Write("Enter the endPoint = ");
endPoint = int.Parse(Console.ReadLine());

int i = startPoint;

while(i <= endPoint)
{
    j = 1;
    while(j <= 5)
     {
        if(i % 5 == 0)
            {
              break;
            }
             Console.WriteLine(i + " x " + j + " = " + (i * j));
             j++;
     }
    Console.WriteLine("-----------------------------");
    i++;
}