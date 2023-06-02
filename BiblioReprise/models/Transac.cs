using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioReprise.models
{
    public class Transac
    {
        private string transacName { get; }
        private DateTime transacDate { get; }

        private float transacAmount { get; }

        private string transacCP { get; }

        public Transac(string transacName, DateTime transacDate, float transacAmount, string transacCP)
        {
            this.transacName = transacName;
            this.transacDate = transacDate;
            this.transacAmount = transacAmount;
            this.transacCP = transacCP;
        }
    }
}
