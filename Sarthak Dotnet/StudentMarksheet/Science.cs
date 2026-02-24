using StudentMarksheet;

class Science : Student
{
    protected int Physics;
    public Science(int rollNo , string Name , int English , int generalStudies , int Physics)
                    :base(rollNo,Name,English,generalStudies)
    {
        this.Physics = Physics;
    }

    public override void PrintResult()
    {
        base.PrintResult();
        Console.WriteLine("Physics Marks : "+Physics);
    }
}