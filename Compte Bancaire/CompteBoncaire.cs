using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire
{
    public abstract class CompteBancaire
    {
        public Client Titulaire { get; }
        public double Solde { get; protected set; }
        public string Devise { get; set; }

        public CompteBancaire(Client leTitulaire, double leSolde, string laDevise)
        {
            Titulaire = leTitulaire;
            Solde = leSolde;
            Devise = laDevise;
        }

        public void Crediter(double montant)
        {
            Solde += montant;
        }

        public abstract bool Debiter(double montant);
    }

}
