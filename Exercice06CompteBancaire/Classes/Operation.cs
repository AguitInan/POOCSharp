using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06CompteBancaire.Classes
{
    public class Operation
    {
        //private int numero;
        private int _id;
        private int _compteId;
        private decimal _montant;
        private static int _index = 0;
        //public int Numero { get => numero; }
        public decimal Montant { get => _montant; }
        public int Id { get => _id; set => _id = value; }
        public int CompteId { get => _compteId; set => _compteId = value; }

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
