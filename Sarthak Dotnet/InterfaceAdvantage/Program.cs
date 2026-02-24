using InterfaceAdvantage;
using VendorLibrary;

class MainClass
{
    static void Main()
    {
        Customer c = new Customer();
        Products p = new Products();
        Order o = new Order();

        Vendor.ProcessData(c);
        Vendor.ProcessData(p);
        Vendor.ProcessData(o);
    }
}