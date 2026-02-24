// See https://aka.ms/new-console-template for more information

using Greetinglibrary;

string name;
Console.Write("Enter Your name ");
name = Console.ReadLine();

Greeting greeting = new Class1();
Console.WriteLine(greeting.GreetMe(name));