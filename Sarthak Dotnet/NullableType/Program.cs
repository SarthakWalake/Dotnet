// See https://aka.ms/new-console-template for more information
int ?i = null;
int j = 10;
int ?k = i +j;

if(k.HasValue)
{
    Console.WriteLine(k);
}
else
{
    Console.WriteLine("Null Value");
}

Console.WriteLine(k.GetValueOrDefault());

bool ?b = null;
Console.WriteLine(b.GetValueOrDefault());
