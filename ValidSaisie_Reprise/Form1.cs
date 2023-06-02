using BiblioReprise.Valid;
using System;

namespace ValidSaisie_Reprise
{
    public partial class Form1 : Form
    {
        Validation valid;
        public Form1()
        {
            InitializeComponent();
            valid = new Validation();

        }
        private void btnEffac_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = String.Empty;
                }
            }
        }

        private void txtbCP_TextChanged(object sender, EventArgs e)
        {
            txtbCP.Text = valid.CheckCP(txtbCP.Text);
        }

        private void txtb_Leave(object sender, EventArgs e)
        {
            TextBox txtb = sender as TextBox;
            string error = "";

            switch (txtb.Name)
            {
                case "txtBName":
                    error = valid.CheckName(txtb.Text);
                    break;
                case "txtBDate":
                    error = valid.CheckDate(txtb.Text);
                    break;
                case "txtBSum":
                    error = valid.CheckAmmount(txtb.Text);
                    break;
                case "txtBCP":
                    error = valid.CheckCP(txtb.Text);
                    break;
                default:
                    break;
            }
            if (error != "" && txtb.Text != "")
            {
                txtb.ForeColor = Color.Red;
                txtb.Text = error;
                btnValid.Enabled = false;
            }
            ALLValid();
        }
        private void ALLValid()
        {
            btnValid.Enabled = (txtbCP.ForeColor == Color.Black && txtbDate.ForeColor == Color.Black && txtbNom.ForeColor == Color.Black && txtbMontant.ForeColor == Color.Black);
        }


    }
}