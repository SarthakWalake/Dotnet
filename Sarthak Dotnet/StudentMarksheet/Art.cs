using StudentMarksheet;

class Art : Student
{
    protected int History;

    public Art(int rollNo , string Name , int English , int generalStudies , int History)
                    :base(rollNo,Name,English,generalStudies)
    {
        this.History = History;
    }

    public override void PrintResult()
    {
        base.PrintResult();
        Console.WriteLine("History Marks : "+History);
    }
}