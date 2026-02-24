
namespace Events
{
    class TestButton
    {
        public event ButtonEventHandler Click;        // Delegate Reference.

        public void OnClick()
        {
            Click();        // Calling Delegate.
        }
    }
}
