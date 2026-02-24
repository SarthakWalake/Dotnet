
namespace Events
{
    class MainClass
    {
        private TestButton btnHello;

        private void SayHello()
        {
            Console.WriteLine("Test Button is Clicked");
        }

        public MainClass()
        {
            this.btnHello = new TestButton();
            this.btnHello.Click += new ButtonEventHandler(this.SayHello);
        }

        static void Main()
        {
            MainClass mc = new MainClass();
            mc.btnHello.OnClick();
        }
    }
}