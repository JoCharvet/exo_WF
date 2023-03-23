using ClassLibraryAddi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Addionneur_4000
{
    public partial class Form1 : Form
    {
        Additionneur addi;
        public Form1()
        {
            InitializeComponent();
            addi = new Additionneur();
           
   

        }

        private void BtnVid_Click(object sender, EventArgs e)
        {
            addi.Vider();
            DisplayRTB.Text = "";
            BtnVid.Enabled = false;
            BtnVal.Enabled = false;
            
        }

        private void BtnVal_Click(object sender, EventArgs e)
        {
            DisplayRTB.Text += "= "+addi.Res+"+ ";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            BtnVid.Enabled = true;
            if (addi.Enab &&  !BtnVal.Enabled)
            {
                BtnVal.Enabled = true;
               
            }
            Button btn = sender as Button;
            DisplayRTB.Text += btn.Text + '+';
            addi.Additionner(int.Parse(btn.Text));
        }

        private void BtnRnd_Click(object sender, EventArgs e)
        {
            BtnVid.Enabled = true;
            if (addi.Enab && !BtnVal.Enabled)
            {
                BtnVal.Enabled = true;
             
            }
            int nb = addi.rnd();
            DisplayRTB.Text += nb.ToString()+ '+';
            addi.Additionner(nb);
        }
    }
}
