using BusinessLibrary;
namespace InterfaceAdvantage
{
    class Customer : IBusiness
    {
        public void DisplayReport()
        {
            Console.WriteLine("Display Customers Details");
        }
    }
}