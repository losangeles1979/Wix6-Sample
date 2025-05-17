namespace Wix6_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messageBoxText = "Thou didst click, and I appeared!";
            string caption = "Wix6-Sample Click Alert!";

            // Use System.Windows.Forms.MessageBox, which only supports buttons and icons as parameters
            MessageBox.Show(messageBoxText, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
