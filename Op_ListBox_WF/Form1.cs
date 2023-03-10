using ClassLibraryAddi;
using System;
using System.Reflection;

namespace Op_ListBox_WF
{
    public partial class Exo_3_2ListBox : Form
    {
        Validation val;
        List<string> errors;
        public Exo_3_2ListBox()
        {
            InitializeComponent();
            val = new Validation();
            errors = new List<string> { "N/A", "Lettre ou - uniquement.", "Ne doit pas dépasser 30 cactères.", "Existe déja" };

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            btnClean.Enabled = true;
            bool nope = true;
            string error =val.CheckName(txtBNewElem.Text); 
            if(error == "")
            { 
                foreach (var item in lstBList.Items)
                {
                    if (item.ToString() == txtBNewElem.Text)
                    {
                        nope = false;
                        error = errors[3];
                    }
                }
            }
            else 
                nope = false;
            if (nope)
                lstBList.Items.Add(txtBNewElem.Text);
            else
                txtBNewElem.Text = error;    
        }
            

        private void btnClean_Click(object sender, EventArgs e)
        {
            lstBList.Items.Clear();
            btnClean.Enabled = false;
            txtBItems.Text = errors[0];
            ErrorClears();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ChangeSelected();
           
        }

        private void ErrorClears()
        {
            
            txtBSelect.Text = errors[0];
            txtBSelected.Text = errors[0];
            txtBText.Text = errors[0];
        }

        private void ChangeSelected()
        {
            if (int.TryParse(txtBSelect.Text, out int index) && index < lstBList.Items.Count && index >= 0)
            {
                txtBSelected.Text = txtBSelect.Text;
                txtBItems.Text = lstBList.Items.Count.ToString();
                txtBText.Text = lstBList.Items[index].ToString();
                lstBList.SelectedIndex = index;

            }
            else
            {
                ErrorClears();
            }
        }

        private void txtBSelect_TextChanged(object sender, EventArgs e)
        {
            btnSelect.Enabled = (txtBSelect.Text != "" );
        }

        private void txtBNewElem_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (txtBNewElem.Text != "");
           
        }
        

        private void txtB_Enter(object sender, EventArgs e)
        {
            TextBox txtb = sender as TextBox;
            bool error = false;
            foreach (string item in errors)
            {
                if (item == txtb.Text)
                {
                    error = true;
                }
            }
            if (error)
            {
                txtb.Text = "";
            }
        }

        private void lstBList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSelected();
        }

        private void Exo_3_2ListBox_Load(object sender, EventArgs e)
        {

        }
    }
}