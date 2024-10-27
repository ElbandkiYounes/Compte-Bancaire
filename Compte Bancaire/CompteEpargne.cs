using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire
{

    public class CompteEpargne : CompteBancaire
    {
        public double TauxInteret { get; set; }

        public CompteEpargne(Client leTitulaire, double leSolde, string laDevise, double leTauxInteret) : base(leTitulaire, leSolde, laDevise)
        {
            TauxInteret = leTauxInteret;
        }

        public void AjouterInterets()
        {
            double interets = Solde * TauxInteret;
            Solde += interets;
        }

        public override bool Debiter(double montant)
        {
            if (montant > Solde / 2)
            {
                Solde -= montant;
                return true;
            }
            return false;

        }
    }
}
