using PolymorphismAssigment;
class HR : Employee
{
    double HRAllowance;

    public HR(string name, double salary, double da, double hra, double allowance)
        : base(name, salary, da, hra)
    {
        HRAllowance = allowance;
    }

    public override double CalculateSalary()
    {
        return base.CalculateSalary() + HRAllowance;
    }
}