// See https://aka.ms/new-console-template for more information

class MainClass{

    static void SingleDimension()
    {
        int[] a ;               // Array Decleration
        a = new int[5];        // Instantiation

        for(int i =0 ; i < 5 ; i++)
        {
            a[i] = i * 10;
        }

        int[] b = {1,2,3,4,5};

        for(int i = 0; i < 5 ; i++)
        {
            Console.WriteLine(a[i]);
        }
    }

    static void TwoDimensional()
    {
        int[,] myArray = new int[2,3];

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0;j < 3; j++)
            {
                Console.Write("Give Value for cell "+i +j+" ");
                myArray[i,j] = int.Parse(Console.ReadLine()); 
            }
        }

        // Printing the values of the Array

        for(int i =0 ;i < 2; i++)
        {
            for(int j = 0;j < 3;j++)
            {
                Console.Write(myArray[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
static void JaggedArray()
{
    int rows;
    Console.Write("Give me Row size of jagged Array ");
    rows = Convert.ToInt32(Console.ReadLine());

    int[][] jaggedArray = new int[rows][];

    // Assigning Columns value for each rows
    for(int i = 0; i < rows; i++)
    {
        Console.Write("Coloum size for Rows " + i+" ");
        int col;
        col = Convert.ToInt32(Console.ReadLine());
        jaggedArray[i] = new int[col];
    }

    Console.WriteLine();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < jaggedArray[i].Length; j++)
        {
            Console.Write("Give input value for cell " + i + j+" ");
            jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    Console.WriteLine();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < jaggedArray[i].Length; j++)
        {
            Console.Write(jaggedArray[i][j]+" ");
        }
        Console.WriteLine();
    }
}

static void ArrayOperation()
{
    int[] a = {5,1,4,3,2};

    Array.Sort(a);

    foreach(int i in a)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("-------------------");

    Array.Reverse(a);

    foreach(int i in a)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("---------------------");

    int[] b = new int[a.Length];
    Array.Copy(a , b , a.Length);

    foreach(int i  in a)
    {
        Console.WriteLine(i);
    }
}



 static void Main()
    {
        // SingleDimension();
        // TwoDimensional();
        JaggedArray();

    }
}