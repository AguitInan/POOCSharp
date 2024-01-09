using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal class CompteEpargne : Compte
    {
        private int _compteId;
        private int _taux;
        private decimal _solde;

        public int CompteId { get => _compteId; set => _compteId = value; }
        public int Taux { get => _taux; }
        public decimal Solde { get => _solde; set => _solde = value; }

        public CompteEpargne(Client c, int t, decimal s = 0) : base(c, s)
        {
            _taux = t;
        }

        public void UpdateSolde()
        {
            _solde += _solde * _taux / 100;
        }

    }
}
