using System.Diagnostics;

namespace additionneur_reprise
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
           

        }

        public void AddToRTB(object sender,EventArgs e)
        {
            
           
        }

        public void SumOfRTB(object sender, EventArgs e)
        {

        }

        public void CleanRTB(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            rtb.Clear();
        }
    }
}