using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal class CompteEpargne : Compte
    {
        private int compteId;
        private int taux;

        public int Taux { get => taux; }
        public int CompteId { get => compteId; set => compteId = value; }

        public CompteEpargne(Client c, int t, decimal s = 0) : base(c, Sauvegarde.Instance, s)
        {
            taux = t;
        }

        public void UpdateSolde()
        {
            solde += solde * taux / 100;
        }

    }
}
