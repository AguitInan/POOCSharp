using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09Hotel.Classes
{
    internal class Chambre
    {
        private int numero;
        private int nbLits;
        private decimal tarif;
        private StatutChambre statut;

        public int Numero { get => numero; set => numero = value; }
        public int NbLits { get => nbLits; set => nbLits = value; }
        public decimal Tarif { get => tarif; set => tarif = value; }
        public StatutChambre Statut { get => statut; set => statut = value; }
    }

    enum StatutChambre
    {
        Libre,
        Occupé,
        EnNettoyage,
    }
}
