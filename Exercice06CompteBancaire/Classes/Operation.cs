using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06CompteBancaire.Classes
{
    public class Operation
    {
        //private int numero;
        private int id;
        private int compteId;
        private decimal montant;
        private static int index = 0;
        //public int Numero { get => numero; }
        public decimal Montant { get => montant; }
        public int Id { get => id; set => id = value; }
        public int CompteId { get => compteId; set => compteId = value; }

        
    }
}
