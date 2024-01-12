using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09Hotel.Classes
{
    internal class Chambre
    {
        private int _numero;
        private int _nbLits;
        private decimal _tarif;
        private StatutChambre _statut;

        public int Numero { get => _numero; set => _numero = value; }
        public int NbLits { get => _nbLits; set => _nbLits = value; }
        public decimal Tarif { get => _tarif; set => _tarif = value; }
        public StatutChambre Statut { get => _statut; set => _statut = value; }
    }

    enum StatutChambre
    {
        Libre,
        Occupé,
        EnNettoyage,
    }
}
