using BusinessLibrary;

namespace InterfaceAdvantage
{
     class Order : IBusiness
    {
        public void DisplayReport()
        {
            Console.WriteLine("Dispalying orders Details");
        }
    }
}
