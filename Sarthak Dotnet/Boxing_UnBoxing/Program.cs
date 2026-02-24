namespace Boxing_UnBoxing
{
    class MainClass
    {
        static void Main()
        {
            int i = 10;
            object o = i;       // Boxing
            i++;
            Console.WriteLine("O is  "+o);
            i = 20;
            o = 30;             // Boxing again so a new box in heap is created.

            Console.WriteLine("O is  "+o);
            Console.WriteLine("i is  "+i);

            int j = (int)o;     // Unboxing to same value type which is boxed.
            Console.WriteLine("j is  "+j);

            // byte b = (byte)o;        This is invalid unboxing. int is boxed so unboxing can be only to int.    
            // Console.WriteLine(b);

            byte b = (byte)(int)o;      // unboxing to int and then explicit type casting to byte.
            Console.WriteLine("b is  "+b);
        }
    }
}