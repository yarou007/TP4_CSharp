using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Banque
{
    internal class ComptePayant : Compte
    {
        public ComptePayant() : base(0) { }
        public ComptePayant( double s) : base(s) { }

        public override void depot(double dp)
        {
            base.depot(dp - 5);
        }

        public override void retrait(double dp)
        {
            base.retrait(dp+5);
        }
    }
}
