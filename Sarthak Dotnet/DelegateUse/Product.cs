

namespace DelegateUse
{
     class Product
    {
        int prodID;
        string prodName;

        public Product(int id , string name)
        {
            this.prodID = id;
            this.prodName = name;
        }

        private void Display()
        {
            Console.WriteLine("Product ID {0}",this.prodID);
            Console.WriteLine("Product Name {0}",this.prodName);
        }

        public void UseService()
        {
            PrintDelegate d = new PrintDelegate(Display);
            PrintingService.Print(d);
        }
    }
}
