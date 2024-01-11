using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercice08Pile.Classes
{
    internal class IHM
    {

        //private List<Compte> listeComptes;
        //private int numeroCompte;

        private Pile<string> pileChaine = new Pile<string>(4);
        private Pile<int> pileEntier = new Pile<int>(4);
        private Pile<Personne> pilePersonne = new Pile<Personne>(4);
        public IHM()
        {
            //listeComptes = new List<Compte>();
        }



        public void Start()
        {
            string choix;
            do
            {
                MenuPrincipal();
                Console.Write("Votre choix : ");
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        Empiler();
                        break;
                    case "2":
                        Depiler();
                        break;
                    case "3":
                        Get();
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
            Console.WriteLine("=== Menu principal ===");
            Console.WriteLine("1. Empiler");
            Console.WriteLine("2. Dépiler");
            Console.WriteLine("3. Récupérer à X");
            Console.WriteLine("0. Quitter\n");
        }







    }
}
