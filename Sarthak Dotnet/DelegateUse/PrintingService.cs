
public delegate void PrintDelegate();   //Declaration.
namespace DelegateUse
{
     class PrintingService
    {
        public static void Print(PrintDelegate d)
        {
            d();
        }
    }
}
