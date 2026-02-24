using DelegateUse;

Customer cust = new Customer(101, "Sarthak");
Product prod = new Product(111, "Bolt");
Employee emp = new Employee(101, "Nayan", 10000, 10520, 20000);
cust.AvailService();
Console.WriteLine("-------------------");
prod.UseService();
Console.WriteLine("-------------------");
emp.GenerateSalarySlip();