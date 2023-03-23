using checkb_radiob;
using System.Security.Cryptography.X509Certificates;

namespace CreerDesFormulaires
{
    public partial class frmMenu : Form
    {
        public int nbCalc;
        public frmMenu()
        {
            InitializeComponent();
            nbCalc = 0;
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter", "Quitter", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue");
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nbCalc++;
            Super_Addionneur_4000.Form1 additionneur = new Super_Addionneur_4000.Form1();
            if (nbCalc>1)
            {
                additionneur.Text = additionneur.Text + " " + nbCalc.ToString();
            }
            additionneur.MdiParent = this;
            additionneur.Show();
        }

        private void checkboxEtRadioButton_Click(object sender , EventArgs e)
        {
           
            frmCheckRB frmChck = new frmCheckRB();
            frmChck.MdiParent=this;
            frmChck.Show();
            
        }

        private void lesListesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Op_ListBox_WF.Exo_3_2ListBox oplist = new Op_ListBox_WF.Exo_3_2ListBox();
            oplist.Show();
        }

        private void controls_Click(object sender, EventArgs e)
        {
            Valide_saisie.Form1 val = new Valide_saisie.Form1();
            val.Show();
        }

        private void listesEtComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LB_CB.LesListes lstCb = new LB_CB.LesListes();
            lstCb.Show();
        }

        private void defilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefilementColor.Form1 defil = new DefilementColor.Form1();
            defil.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}