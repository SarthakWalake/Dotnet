using IComparableSorting;

public struct student : IComparable
{
    public int id;

    public student(int id)
    {
        this.id = id;
    }

    public int CompareTo(object p)
    {
        student s = (student) p;
        return this.id.CompareTo(s.id);
    }

    public override string ToString()
    {
        return id.ToString();
    }
}

class MainClass
{
    static void Main()
    {
        IComparable[] yourArray = new IComparable[5];
        yourArray[0] = new student(50);
        yourArray[1] = new student(10);
        yourArray[2] = new student(40);
        yourArray[3] = new student(30);
        yourArray[4] = new student(20);

        Utlitiy.Sort(yourArray);

        foreach(student s in yourArray)
        {
            Console.WriteLine(s);
        }
    }
}