namespace additionneur_reprise2
{
    public partial class Form1 : Form
    {
        int res;
        public Form1()
        {
            InitializeComponent();
            res=0;
        }

        private void AfficheChiffre(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            res +=  int.Parse(btn.Text);
            richTextBox1.Text += (richTextBox1.Text == "") ? btn.Text : " + " + btn.Text ;
            if (!button11.Enabled)
            {
                button11.Enabled = true;
            }
            if (richTextBox1.Text.Length>3 && int.Parse(btn.Text) != 0 )
            {
                button12.Enabled = true;
            }

        }

        private void Vider(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            res = 0;
            button11.Enabled = false;
            button12.Enabled = false;
        }

        private void Calculer(object sender, EventArgs e)
        {
            richTextBox1.Text += " = " + res;
            button12.Enabled = false;
        }

      
    }
}