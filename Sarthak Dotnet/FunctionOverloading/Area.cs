class Area
{
    public void CalculateArea(int side)
    {
        int area = side * side;
        Console.WriteLine(" Area of the Square is "+area);
    }

    public void CalculateArea(int l , int b)
    {
        int area = l * b;
        Console.WriteLine("Area of Rectangle is "+area);
    }

    public void CalculateArea(double r)
    {
        double area = 3.14 * (r * r);
        Console.WriteLine("Area of circle is "+area);
    }

    public void Run()
    {
        int choice , length , breadth , side;
        double radius;
        char option;

        do
        {
            Console.WriteLine("For which shape do want to calculate the Area");
            Console.WriteLine("1 Area of Square");
            Console.WriteLine("2 Area of Rectangle");
            Console.WriteLine("3 Area of Circle");

            Console.Write("Choose your choice ");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                Console.Write("Enter the side of Square ");
                side = int.Parse(Console.ReadLine());
                CalculateArea(side);
                break;

                case 2:
                Console.Write("Enter the length of Rectangle ");
                length = int.Parse(Console.ReadLine());
                Console.Write("Enter the breadth of Rectangle ");
                breadth = int.Parse(Console.ReadLine());
                CalculateArea(length,breadth);
                break;

                case 3:
                Console.Write("Enter the radius of Circle ");
                radius = double.Parse(Console.ReadLine());
                CalculateArea(radius);
                break;

                default:
                Console.WriteLine("Invaild option");
                break;
            }
                Console.Write("Do You Have Any Other Requirement('Y|N'): ");
                option = char.Parse(Console.ReadLine());

        }while(option == 'y' | option=='Y');
    }

}