using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAddi.Emprunts
{
    public class Emprunt : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string nom = "";
        private double capEmprunt = 1000;
        private int dureeEmprunt = 2;
        private double tauxEmpruntAnnuel =7;
        private EnumPeriod periodiciteChoisie = EnumPeriod.Mensuelle;
        private double montantPeriod = 0;
        //private Dictionary<string,int> periodicite = Enum.GetValues(typeof(EnumPeriod))
        //                                                .Cast<EnumPeriod>().ToDictionary(k=>k.ToString(),v=>(int)v);
        public string Nom
        {
            get { return nom; }
            set { nom = value; NotifyPropertyChanged(); }
        }
        public double CapEmprunt
        {
            get => capEmprunt;
            set { capEmprunt = value; NotifyPropertyChanged(); CalculeMontantPeriod(); }
        }
        public int DureeEmprunt
        {
            get =>  dureeEmprunt;
            set { dureeEmprunt = value; NotifyPropertyChanged(); CalculeMontantPeriod(); }
        }
        public double TauxEmpruntAnnuel
        {
            get => tauxEmpruntAnnuel;
            set { tauxEmpruntAnnuel = value; NotifyPropertyChanged(); CalculeMontantPeriod(); }
        }
        public EnumPeriod PeriodiciteChoisie
        {
            get => periodiciteChoisie;
            set { periodiciteChoisie = value; NotifyPropertyChanged(); CalculeMontantPeriod(); }
        }
        public double MontantPeriod
        {
            get => montantPeriod;
            set { montantPeriod = value; NotifyPropertyChanged(); }
        }

        public Emprunt() { }
        public Emprunt(string _nom, double _capEmprunt, int _dureeEmpruntAnnee, double _tauxEmpruntAnnuel, EnumPeriod _periodiciteChoisie, double montantPeriod)
        {
            this.Nom = _nom;
            this.CapEmprunt = _capEmprunt;
            this.DureeEmprunt = _dureeEmpruntAnnee;
            this.tauxEmpruntAnnuel = (int)_periodiciteChoisie;
            this.periodiciteChoisie = _periodiciteChoisie;
            this.montantPeriod = 0;
        }


        public void CalculeMontantPeriod()
        {
            double K = this.capEmprunt;
            double t = this.tauxEmpruntAnnuel * ((int)this.periodiciteChoisie / 12.0d);
            double n = this.dureeEmprunt;
            this.montantPeriod = K * (t / (1 - Math.Pow((1 + t), -n)));
        }


        //private void CalculerMontantPeriode(EnumPeriod _periodChoisie)
        //{

        //}

        //public  Emprunt TestEmprunt(string _nom, double _capEmprunt,int _dureeEmpruntAnnee ,double _tauxEmpruntAnnuel, EnumPeriod _periodChoisie,out string error )
        //{
        //    error = "";
        //    double montantPeriod = _capEmprunt * Math.Pow(_tauxEmpruntAnnuel / 1 - (1 + _tauxEmpruntAnnuel), _dureeEmpruntAnnee / (int)_periodChoisie);
        //    if (_capEmprunt<0)
        //    {
        //        error = "le montant doit être positif";
        //        return null;
        //    }
        //    else
        //    return new Emprunt(_nom,_capEmprunt,_dureeEmpruntAnnee,_tauxEmpruntAnnuel,_periodChoisie,montantPeriod);

        //}


    }

}
