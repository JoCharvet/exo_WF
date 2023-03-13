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
        Color color;

        int r = 0;
        int v = 0;
        int b = 0;
        public int R
        {
            get { return r; }
            set { r = value; NotifyPropertyChanged(); Color = Color.FromArgb(this.r, this.v, this.b); }
        }

        public int V
        {
            get { return v; }
            set { v = value; NotifyPropertyChanged(); Color = Color.FromArgb(this.r, this.v, this.b); }
        }

        public int B
        {
            get { return b; }
            set { b = value; NotifyPropertyChanged(); Color = Color.FromArgb(this.r, this.v, this.b); }
        }

        public Color Color 
        {
            get { return color; }
            set { color = value;  } 
        }


        public MaCouleur() { }


        public MaCouleur(Color color)
        {
            this.color = color;
            this.r = color.R;
            this.v = color.G;
            this.b = color.B;
        }
    }
}
