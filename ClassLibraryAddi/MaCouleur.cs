using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAddi
{
    public class MaCouleur :  INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        private Color color;


        public int R
        {
            get { return color.R; }
            set { NotifyPropertyChanged(); Color = Color.FromArgb(value, color.G, color.B); }
        }

        public int V
        {
            get { return color.G; }
            set { NotifyPropertyChanged(); Color = Color.FromArgb(color.R, value, color.B); }
        }

        public int B
        {
            get { return color.B; }
            set {  NotifyPropertyChanged(); Color = Color.FromArgb(color.R, color.G, value); }
        }

        public Color Color 
        {
            get { return color; }
            set { color = value;  } 
        }


        public MaCouleur() 
        {
            color =Color.White;
        }


        public MaCouleur(Color color)
        {
            this.color = color;
        }
    }
}
