// See https://aka.ms/new-console-template for more information
int a , b , c;
Console.Write("Enter the value of a ");
a = int.Parse(Console.ReadLine());

Console.Write("Enter the value of b ");
b = int.Parse(Console.ReadLine());

Console.Write("Enter the value of c ");
c = int.Parse(Console.ReadLine());

 if (a <= b)
        {
            if (a <= c)
            {
                if (b <= c)
                    Console.WriteLine(a + " " + b + " " + c);
                else
                    Console.WriteLine(a + " " + c + " " + b);
            }
            else
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
        }
        else
        {
            if (b <= c)
            {
                if (a <= c)
                    Console.WriteLine(b + " " + a + " " + c);
                else
                    Console.WriteLine(b + " " + c + " " + a);
            }
            else
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
}
