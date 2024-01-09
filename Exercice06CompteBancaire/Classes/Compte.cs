using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06CompteBancaire.Classes
{
    internal abstract class Compte
    {
        private string _numeroCompte;
        private decimal _solde;
        private Client _client;
        private List<Operation> _listeOperation;

        public Compte(Client client)
        {
            _client = client;
            _solde = 0m;
            _listeOperation = new();

        }

        public Compte(Client client, decimal soldeInitial) : this(client)
        {
            _solde = soldeInitial;

        }


        //public Compte(Client c, int t, decimal s = 0)
        //{

        //}


    }
}
