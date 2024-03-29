using ClassLibraryAddi.Emprunts;
using System.Windows.Forms;

namespace Emprunts
{
    public partial class Form1 : Form
    {
        private Emprunt emprunt;
        public Form1()
        {
            InitializeComponent();
            emprunt = new Emprunt();
            foreach (var item in (EnumPeriod[])Enum.GetValues(typeof(EnumPeriod)))
            {
                listBox1.Items.Add(item);
            }
            listBox1.SelectedIndex = 0;
            //listBox1.Items.AddRange((object[])periods);        
            lblNbMois.DataBindings.Add("Text", emprunt,"DureeEmprunt",true,DataSourceUpdateMode.OnPropertyChanged);
            hscbDuree.DataBindings.Add("Value",emprunt,"DureeEmprunt",true,DataSourceUpdateMode.OnPropertyChanged);
            lblMontant.DataBindings.Add("Text", emprunt, "MontantPeriod", true, DataSourceUpdateMode.OnPropertyChanged);
            txtbCapitalE.DataBindings.Add("Text", emprunt, "CapEmprunt", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtbNom.Clear();
            txtbCapitalE.Clear();
            hscbDuree.Value = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumPeriod enuCourante = (EnumPeriod)listBox1.SelectedItem;
            emprunt.PeriodiciteChoisie = enuCourante;
            hscbDuree.Minimum = (int)enuCourante;
            hscbDuree.SmallChange= (int)enuCourante;
            emprunt.CalculeMontantPeriod();
            lblNbRemb.Text = emprunt.CalculerNbMensualite().ToString();
            hscbDuree.Value = (int)enuCourante;

        }

        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            double.TryParse(radio.Tag.ToString() ,out double b);
            emprunt.TauxEmpruntAnnuel = b;
            emprunt.CalculeMontantPeriod();
            
        }

        //private void hscbDuree_ValueChanged(object sender, EventArgs e)
        //{
        //    emprunt.DureeEmprunt = hscbDuree.Value;
        //}
    }
}