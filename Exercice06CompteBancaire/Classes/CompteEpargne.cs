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

        

    }
}
