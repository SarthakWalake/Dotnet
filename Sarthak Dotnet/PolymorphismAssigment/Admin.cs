using PolymorphismAssigment;
class Admin : Employee
{
    double AdminAllowance;

    public Admin(string name, double salary, double da, double hra, double allowance)
        : base(name, salary, da, hra)
    {
        AdminAllowance = allowance;
    }

    public override double CalculateSalary()
    {
        return base.CalculateSalary() + AdminAllowance;
    }
}
