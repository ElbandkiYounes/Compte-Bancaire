using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire
{
    public class CompteCourant : CompteBancaire
    {
        public double DecouvertAutorise { get; set; }
        public int NumeroCB { get; set; }

        public CompteCourant(Client leTitulaire, double leSolde, string laDevise, double leDecouvertAutorise, int numeroCB) : base(leTitulaire, leSolde, laDevise)
        {
            DecouvertAutorise = leDecouvertAutorise;
            NumeroCB = numeroCB;
        }

        public override bool Debiter(double montant)
        {
            if (montant <= Solde + DecouvertAutorise)
            {
                Solde -= montant;
                return true;
            }
            return false;
        }
    }
}
