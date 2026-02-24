using StudentMarksheet;

class Commerce : Student
{
    protected int Accounts;

    public Commerce(int rollNo , string Name , int English , int generalStudies , int Accounts)
                    :base(rollNo,Name,English,generalStudies)
    {
        this.Accounts = Accounts;
    }

      public override void PrintResult()
    {
        base.PrintResult();
        Console.WriteLine("Accounts Marks : "+Accounts);
    }

}