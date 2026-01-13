// See https://aka.ms/new-console-template for more information
using Vehical.Car;

namespace MainMethod
{

    public class Program()
    {
        public static void main(string[] args)
        {
            int n=20;
string name;
bool status=true;

Console.WriteLine("Enter name" );
name=Console.ReadLine();

Console.WriteLine("ENter Id");
int id=int.Parse(Console.ReadLine());
Console.WriteLine("Name:"+name);
Console.WriteLine("Hello, World!");

Car c=new Car();
c.display();
        }
    }

}