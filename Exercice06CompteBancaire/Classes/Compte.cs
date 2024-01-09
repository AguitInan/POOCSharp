using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06CompteBancaire.Classes
{
    internal abstract class Compte
    {
        private string _numeroCompte;
        private double _solde;
        private Client _client;
        //private Utilisateur props;
        private List<Operation> _listeOperation;

        public Compte()
        {

        }
        //public Compte(string numeroCompte)
        //{
        //    foreach (Compte compte in Journalisation.GetListeComptesBancaires())
        //    {
        //        if (compte.NumeroCompte == numeroCompte)
        //        {
        //            NumeroCompte = compte.NumeroCompte;
        //            Props = compte.Props;
        //            ListeOperation = compte.ListeOperation;
        //            Solde = compte.Solde;
        //            break;
        //        }
        //    }
        //}

        public Compte(Client c, int t, decimal s = 0)
        {

        }


    }
}
