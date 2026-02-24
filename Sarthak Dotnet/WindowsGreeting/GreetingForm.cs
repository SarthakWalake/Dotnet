namespace WindowsGreeting
{
    public partial class frmGreeting : Form
    {
        public frmGreeting()
        {
            InitializeComponent();
        }

     
        private void btnHi_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;  
            MessageBox.Show("You clicked: " + btn.Name);
           

        }
    }
}
