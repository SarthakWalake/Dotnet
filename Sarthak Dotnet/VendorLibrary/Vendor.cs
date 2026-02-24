using BusinessLibrary;

namespace VendorLibrary;

public class Vendor
{
    public static void ProcessData(IBusiness business)
    {
        business.DisplayReport();
    }
}
