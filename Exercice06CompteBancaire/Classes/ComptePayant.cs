using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal class ComptePayant : Compte
    {

        private int _compteId;
        private decimal _coutOperation;

        public int CompteId { get => _compteId; set => _compteId = value; }
        public decimal CoutOperation { get => _coutOperation; set => _coutOperation = value; }

        public ComptePayant(Client c, decimal t = 2, decimal s = 0) : base(c, s)
        {
            _coutOperation = t;
        }

        
    }
}
