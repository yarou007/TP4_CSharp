using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Banque
{
    internal class Compte
    {
        private int code;
        protected double solde;

        public int Code { get => code;  }
        public double Solde { get => solde;  }

        private static int i = 0;
        public Compte() {
            Compte.i++;
            this.code = Compte.i;
            this.solde = 0;
        }
        public Compte(double solde)
        {
            Compte.i++;
            this.code = Compte.i;
            this.solde = solde;
        }
        public override string ToString()
        {
            return "Compte: "+this.code + " Solde: " + this.solde; 
        }
        public virtual void depot(double dp) {
            this.solde += dp;
            Console.WriteLine("Depot avec succés");

        }

        public virtual void retrait(double dp) { 
           this.solde -= dp;
            Console.WriteLine("Retrait avec succés");
        }



    }
}
