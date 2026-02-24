using PolymorphismAssigment;
class Software : Employee
{
    double ProjectAllowance;

    public Software(string name, double salary, double da, double hra, double allowance)
        : base(name, salary, da, hra)
    {
        ProjectAllowance = allowance;
    }

    public override double CalculateSalary()
    {
        return base.CalculateSalary() + ProjectAllowance;
    }
}