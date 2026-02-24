using System.Collections;
class MainClass
{
    static void Main()
    {
        int[] intArray = { 1,2,3,4,5};
        IEnumerable en = intArray;

        IEnumerator ent = en.GetEnumerator();

        while(ent.MoveNext())
        {
            Console.WriteLine(ent.Current);
        }

        ent.Reset();
        Console.WriteLine();

        while(ent.MoveNext())
        {
            Console.WriteLine(ent.Current);
        }
    }
}