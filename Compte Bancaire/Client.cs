using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire
{
    public class Client
    {
        public int Numero { get; }
        public string Nom { get; }
        public string Prenom { get; }
        public List<CompteBancaire> Comptes { get; set; }

        public Client(int leNumero, string leNom, string lePrenom)
        {
            Comptes = new List<CompteBancaire>();
            Numero = leNumero;
            Nom = leNom;
            Prenom = lePrenom;
        }
        
    }

}
