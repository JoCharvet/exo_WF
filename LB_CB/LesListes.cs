namespace LB_CB
{
    public partial class LesListes : Form
    {

        private string [] source;
        private string [] target;
        public LesListes()
        {
            InitializeComponent();
            target = new string[0];
            source = new string[] { "Allemagne", "Belgique", "Bulgarie", "Espagne", "France", "Grece", "Japon", "Portugal" };
            comboSource.Items.AddRange(source);
        }

        private void btnSToT_Click(object sender, EventArgs e)
        {
            lstBCible.Items.Add(comboSource.SelectedItem);
            comboSource.Items.Remove(comboSource.SelectedItem);
            comboSource.SelectedIndex = -1;
        }

        private void btnSToTAll_Click(object sender, EventArgs e)
        {
            
            foreach (string item in comboSource.Items)
            {
                lstBCible.Items.Add(item);
            }
            comboSource.Items.Clear();
            comboSource.SelectedIndex = -1;
        }

        private void btnTToS_Click(object sender, EventArgs e)
        {
            comboSource.Items.Add(lstBCible.SelectedItem);
            lstBCible.Items.Remove(lstBCible.SelectedItem);
            lstBCible.ClearSelected();
        }

        private void btnTToSAll_Click(object sender, EventArgs e)
        {
            foreach (string item in lstBCible.Items)
            {
                comboSource.Items.Add(item);
            }
            lstBCible.Items.Clear();
            lstBCible.ClearSelected();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int ind = lstBCible.SelectedIndex;
            if (ind>0)
            {
                string temp =(string) lstBCible.SelectedItem;
                lstBCible.Items[ind] = lstBCible.Items[ind-1];
                lstBCible.Items[ind - 1] = temp;
                lstBCible.SelectedItem = lstBCible.Items[ind - 1];
            }      
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int ind = lstBCible.SelectedIndex;
            if (ind < lstBCible.Items.Count-1)
            {
                string temp = (string)lstBCible.SelectedItem;
                lstBCible.Items[ind] = lstBCible.Items[ind + 1];
                lstBCible.Items[ind + 1] = temp;
                lstBCible.SelectedItem = lstBCible.Items[ind + 1];
            }
        }

        private void comboSource_SelectedIndexChanged(object sender, EventArgs e)
        {
             btnSToT.Enabled = (comboSource.SelectedIndex !=-1);
             btnSToTAll.Enabled = (comboSource.SelectedIndex != -1);
        }

        private void lstBCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool select = (lstBCible.SelectedIndex != -1);
            btnTToS.Enabled = select;
            btnTToSAll.Enabled = select;
            btnUp.Enabled = select;
            btnDown.Enabled = select;
        }

        //private void comboSource_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    btnSToT.Enabled = ((string)lstBCible.SelectedValue !=-);
        //    btnSToTAll.Enabled = ((string)lstBCible.SelectedValue != "");
        //}
    }
}