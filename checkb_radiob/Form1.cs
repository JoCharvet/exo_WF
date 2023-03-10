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

        private void txtBInput_TextChanged(object sender, EventArgs e)
        {
            if (txtBInput.Text != "" && !gBChoices.Enabled)
                gBChoices.Enabled = true;
            txtBOutput.Text=txtBInput.Text;
        }

        private void cBBGColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                txtBOutput.BackColor = ColorTranslator.FromHtml(rb.Tag.ToString());

        }

        private void cbCharColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                txtBOutput.ForeColor = ColorTranslator.FromHtml(rb.Tag.ToString());
        }

        private void cBCaseChange_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                txtBOutput.CharacterCasing = (rb.Text == "Minuscules") ? CharacterCasing.Lower:CharacterCasing.Upper;
            }
            else
            {
                txtBOutput.CharacterCasing = CharacterCasing.Normal;
                txtBOutput.Text = txtBInput.Text;
            }
            
           
        }

        private void gBChar_EnabledChanged(object sender, EventArgs e)
        {
            if (!gBChar.Enabled)
                txtBOutput.ForeColor = Color.Black;
        }

        private void gBBackground_EnabledChanged(object sender, EventArgs e)
        {
            
            if(!gBBackground.Enabled)
            {
                GroupBox gb = sender as GroupBox;
                txtBOutput.BackColor = Color.White;
                foreach (RadioButton item in   gb.Controls)
                {
                    item.Checked = false;
                }
            }
               
        }

        private void gBCase_EnabledChanged(object sender, EventArgs e)
        {
            if (!gBBackground.Enabled)
                txtBOutput.Text = txtBInput.Text;
        }
        //private void ResetRadio(GroupBox _gb)
        //{
        //    foreach (RadioButton item in _gb.Controls)
        //    {
        //        item.Checked = false;
        //    }
        //}
    }
}