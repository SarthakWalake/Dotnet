using DelegateRealSceneriao;


object[] data = new object[]
{
    new UserProfile("01Name", 23 , 7.5 , 11.5),
    new UserProfile("22Name", 33 , 1.7 , 4.5),
    new UserProfile("04Name", 42 , 3.5 , 14),
    new UserProfile("03Name", 26 , 2.5 , 12),
    new UserProfile("12Name", 21 , 2.1 , 10)
};

CompareFn fnn = new CompareFn(UserProfile.CompareByName);

Console.WriteLine("before Sorting.......");
PrintData(data);

Utilities.Sort(data, fnn);

Console.WriteLine("\nAfter sorting by name.......");
PrintData(data);

 static void PrintData(object[] dataArray)
{
    foreach(UserProfile up in dataArray)
    {
        Console.WriteLine("{0}\t{1}\t{2}\t{3}",
            up.Name, up.Age, up.Salary, up.Experience);
    }
}
