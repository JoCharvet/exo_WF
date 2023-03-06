using System;

namespace ClassLibraryAddi
{
    public class Additionneur
    {
        private int res = 0;
        private bool enab = false;
        private Random random = new Random();

        public int Res { get => res; }
        public bool Enab { get => enab; }

        public void Vider()
        {
            this.res = 0;
            this.enab = false;
        }

        public int Additionner(int _nb)
        {
            if (!enab)
            {
                this.enab = true;
            }
            return res += _nb;
        }

        public int rnd()
        {
            return this.random.Next(0, 10);
        }
    }

    }