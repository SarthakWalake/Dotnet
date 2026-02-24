namespace PolymorphismAssigment
{
    
class Employee
{
    static int counter = 1;   // Auto ID generator

    public int EmpId;
    public string EmpName;
    public double Salary, DA, HRA;

    public Employee(string name, double salary, double da, double hra)
    {
        EmpId = counter++;
        EmpName = name;
        Salary = salary;
        DA = da;
        HRA = hra;
    }

    public virtual double CalculateSalary()
    {
        return Salary + DA + HRA;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\nEmployee ID: " + EmpId);
        Console.WriteLine("Employee Name: " + EmpName);
        Console.WriteLine("Basic Salary: " + Salary);
        Console.WriteLine("DA: " + DA);
        Console.WriteLine("HRA: " + HRA);
        Console.WriteLine("Total Salary: " + CalculateSalary());
        }
    }
}







