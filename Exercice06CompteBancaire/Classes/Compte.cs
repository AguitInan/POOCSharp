using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06CompteBancaire.Classes
{
    internal abstract class Compte
    {
        private string numeroCompte;
        private double solde;
        //private Utilisateur props;
        private List<Operation> listeOperation;

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
        
    }
}
