using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal class ComptePayant : Compte
    {

        private int compteId;
        private decimal coutOperation;

        public decimal CoutOperation { get => coutOperation; set => coutOperation = value; }
        public int CompteId { get => compteId; set => compteId = value; }

        public ComptePayant(Client c, decimal cOperation = 2, decimal s = 0) : base(c, Sauvegarde.Instance, s)
        {
            coutOperation = cOperation;
        }

        
    }
}
