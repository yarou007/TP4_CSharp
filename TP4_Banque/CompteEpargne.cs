using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Banque
{
    internal class CompteEpargne : Compte
    {
         private double tauxInteret = 0.06;

        public CompteEpargne():base(0)
        {
            
        }
        public CompteEpargne(double s) : base(s)
        {

        }

        public void calculInteret() {

            this.solde += this.solde * this.tauxInteret;         
        }
        
        





    }
}
