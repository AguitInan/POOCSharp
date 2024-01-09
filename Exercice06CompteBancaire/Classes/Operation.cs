using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06CompteBancaire.Classes
{
    internal class Operation
    {
        private static int _count = 0;

        private int _id;
        private int _compteId;
        private decimal _montant;

        public int Id { get => _id; set => _id = value; }
        public int CompteId { get => _compteId; set => _compteId = value; }
        public decimal Montant { get => _montant; }

        private Operation()
        {
            
        }

        public Operation(decimal m, int compteId) : this()
        {
            CompteId = compteId;
            _montant = m;
        }

        public override string ToString()
        {
            return "Id opération : " + Id + "\n" +
                "Montant opération : " + Montant;
        }
    }
}
