namespace EmployeeDetails
{
    class Employee
    {
        protected int _empId;
        private static int id = 100;

        protected string _empName;
        protected double _basicSalary;
        

         public Employee(string empName , double basicSalary )
        {
            _empId = id++;
            this._empName = empName;
            this._basicSalary = basicSalary;
        }

        public virtual double GetHR()
        {
             return 0;
        }
        public virtual double GetDA()
        { 
            return 0;
        }
        public virtual double GetSoftwareAllowance()
        {
             return 0;
        }
        public virtual double GetTotalSalary() 
        {
             return _basicSalary;
        }

        public virtual void PrintSalaryDetails()
        {
            Console.WriteLine("Employee ID: " + _empId);
            Console.WriteLine("Employee Name: " + _empName);
            Console.WriteLine("Basic Salary: " + _basicSalary);
        }
    }

     class HR : Employee
    {
        protected double hr;

        public HR(string name, double basic, double hrAmount)
            : base(name, basic)
        {
           this.hr = hrAmount;
        }
        public override double GetHR()
        {
            return hr;
        }
    }

    class DA : HR
    {
        protected double da;

        public DA(string name, double basic, double hrAmount, double daAmount)
            : base(name, basic, hrAmount)
        {
            this.da = daAmount;
        }

        public override double GetDA()
        {
            return da;
        }
    }

     class SoftwareAllowance : DA
    {
        protected double softwareAllowance;

        public SoftwareAllowance(string name, double basic, double hrAmount,
                                 double daAmount, double softwareAmount)
            : base(name, basic, hrAmount, daAmount)
        {
            this.softwareAllowance = softwareAmount;
        }

        public override double GetSoftwareAllowance()
        {
            return softwareAllowance;
        }

        public override double GetTotalSalary()
        {
            return _basicSalary + GetHR() + GetDA() + GetSoftwareAllowance();
        }

        public override void PrintSalaryDetails()
        {
            Console.WriteLine("\n========= Employee Salary =========");
            Console.WriteLine("Employee ID: " + _empId);
            Console.WriteLine("Employee Name: " + _empName);
            Console.WriteLine("Basic Salary: " + _basicSalary);
            Console.WriteLine("HR Allowance: " + GetHR());
            Console.WriteLine("DA Allowance: " + GetDA());
            Console.WriteLine("Software Allowance: " + GetSoftwareAllowance());
            Console.WriteLine("Total Salary: " + GetTotalSalary());
            Console.WriteLine("===================================");
        }
    }
}