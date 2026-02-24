

namespace DelegateUse
{
     class Customer
    {
        int custID;
        string custName;

        public Customer(int id , string name)
        {
            this.custID = id;
            this.custName = name;
        }

        private void Display()
        {
            Console.WriteLine("Cust ID {0}",this.custID);
            Console.WriteLine("Cust Name {0}", this.custName);
        }

        public void AvailService()
        {
            PrintDelegate d = new PrintDelegate(Display);
            PrintingService.Print(d);
        }
    }
}
