namespace dummy_windows_application
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations. You just wasted 2 seconds of your life.");
        }
    }
}
