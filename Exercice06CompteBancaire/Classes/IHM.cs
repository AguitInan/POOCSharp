using Exercice06CompteBancaire.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06CompteBancaire.Classes
{
    internal class IHM
    {
        private List<Compte> listeComptes;
        private int numeroCompte;
        public IHM()
        {
            listeComptes = new List<Compte>();
        }

        public void Start()
        {
            string choix;
            do
            {
                MenuPrincipal();
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        ActionCreationCompte();
                        break;
                    case "2":
                        ActionDepot();
                        break;
                    case "3":
                        ActionRetrait();
                        break;
                    case "4":
                        ActionAfficherOperationsEtSolde();
                        break;
                    case "5":
                        ActionCalculeInteretCompteEpargne();
                        break;
                    case "0":
                        //Quitter la console
                        Environment.Exit(0);
                        break;
                }

            } while (choix != "0");
        }

        private void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("-----Menu principal-----");
            Console.WriteLine("1. Lister les comptes bancaires");
            Console.WriteLine("2. Créer un compte bancaire");
            Console.WriteLine("3. Effectuer un dépôt");
            Console.WriteLine("4. Effectuer un retrait");
            Console.WriteLine("5. Afficher les opérations et le solde");
            Console.WriteLine("0. Quitter le programme");
        }

        private void MenuCreationCompte()
        {
            Console.WriteLine("1. Créer un compte courant");
            Console.WriteLine("2. Créer un compte épargne");
            Console.WriteLine("3. Créer un compte payant");
            Console.WriteLine("0. Annuler la création de compte");
        }


        private void ActionCreationCompte()
        {
            Console.Clear();
            Console.WriteLine("---Information du client");
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le prénom : ");
            string prenom = Console.ReadLine();
            Console.Write("Merci de saisir le téléphone : ");
            string telephone = Console.ReadLine();
            Client client = new Client(nom, prenom, telephone);
            Console.Write("Solde initial : ");
            string chaineSolde = Console.ReadLine();
            decimal solde = (chaineSolde == "") ? 0 : Convert.ToDecimal(chaineSolde);
            Console.WriteLine("---Type de compte : ");
            MenuCreationCompte();
            Compte compte = null;
            string choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    compte = new Compte(client, Sauvegarde.Instance, solde);
                    break;
                case "2":
                    Console.Write("Merci de saisir le taux : ");
                    int taux = Convert.ToInt32(Console.ReadLine());
                    compte = new CompteEpargne(client, taux, solde);
                    break;
                case "3":
                    Console.WriteLine("Merci de saisir le cout de chaque opération : ");
                    int cout = Convert.ToInt32(Console.ReadLine());
                    compte = new ComptePayant(client, cout, solde);
                    break;
            }
            if (compte != null)
            {
                //listeComptes.Add(compte);
                Sauvegarde.Instance.CreationCompte(compte);
                Console.WriteLine("Compte crée avec le numéro : " + compte.Numero);
            }
            else
            {
                Console.WriteLine("Erreur création compte");
            }
            Console.Read();
        }

    }
}
