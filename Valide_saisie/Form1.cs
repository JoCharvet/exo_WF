using ClassLibraryAddi;
namespace Valide_saisie
{
    public partial class Form1 : Form
    {
        Validation valid;
        public Form1()
        {
            InitializeComponent();
            valid = new Validation();
        }

        private void btnval_Click(object sender, EventArgs e)
        {
            string message = $"{lblNom.Text} : {txtBName.Text} \n" +
                $"{lbldate.Text} : {txtBDate.Text} \n " +
                $"{lblmontant.Text} : {txtBSum.Text} \n" +
                $"{lblcode.Text} : {txtBCP.Text}";
            string title = "Validation effectuée";
            MessageBox.Show(message, title);
        }

        private void btneff_Click(object sender, EventArgs e)
        {
            txtBName.Text = "";
            txtBDate.Text = "";
            txtBSum.Text = "";
            txtBCP.Text = "";

        }

        private void txtB_FocusON(object sender, EventArgs e) 
        { 
            TextBox txtb= sender as TextBox;
            if (txtb.ForeColor==Color.Red)
            {
                txtb.Text = "";
                txtb.ForeColor = Color.Black;
            }
            
        }

        private void txtB_FocusOff(object sender, EventArgs e)
        {
            TextBox txtb= sender as TextBox;
            string error ="";
            
            switch (txtb.Name)
            {
                case "txtBName":
                    error = valid.CheckName(txtb.Text);                  
                    break;
                case "txtBDate":
                    error = valid.CheckDate(txtb.Text);
                    break;
                case "txtBSum":
                    error = valid.CheckSum(txtb.Text);
                    break;
                case "txtBCP":
                    error = valid.CheckCP(txtb.Text);
                    break;
                default:
                    break;   
            }
            if (error != "" && txtb.Text !="")
            {
                txtb.ForeColor = Color.Red;
                txtb.Text = error;
                btnval.Enabled = false;
            }
            else 
                btnval.Enabled = true;
        }

     

     
    }
}