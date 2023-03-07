namespace checkb_radiob
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cBBackG_CheckedChanged(object sender, EventArgs e)
        {
            gBBackground.Enabled = !gBBackground.Enabled;
        }

        private void cBForeC_CheckedChanged(object sender, EventArgs e)
        {
            gBChar.Enabled = !gBChar.Enabled;
        }

        private void cBCase_CheckedChanged(object sender, EventArgs e)
        {
            gBCase.Enabled = !gBCase.Enabled;   
        }
    }
}