using ClassLibraryAddi;
using System.Drawing.Text;

namespace DefilementColor
{
    public partial class Form1 : Form
    {
        public MaCouleur macol;
        public Form1()
        {
            macol = new MaCouleur(Color.BlanchedAlmond);
            InitializeComponent();
            nudRouge.DataBindings.Add("Value", macol, "R", true,DataSourceUpdateMode.OnPropertyChanged);
            nudVert.DataBindings.Add("Value", macol, "V", true, DataSourceUpdateMode.OnPropertyChanged);
            nudBleu.DataBindings.Add("Value", macol, "B", true, DataSourceUpdateMode.OnPropertyChanged);
            hsbRouge.DataBindings.Add("Value", macol, "R", true, DataSourceUpdateMode.OnPropertyChanged);
            hsbVert.DataBindings.Add("Value", macol, "V", true, DataSourceUpdateMode.OnPropertyChanged);
            hsbBleu.DataBindings.Add("Value",macol,"B",true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void changeColor2(object sender, EventArgs e)
        {
            affichageCol.BackColor = macol.Color;
            txtBRouge.BackColor = Color.FromArgb(macol.R,0,0);
            txtBVert.BackColor = Color.FromArgb(0, macol.V,0);
            txtBBleu.BackColor = Color.FromArgb(0, 0,macol.B);
        }

        
    }
}