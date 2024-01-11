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
        private Pile<int> pileEntier;
        private Pile<Personne> pilePersonne = new Pile<Personne>(4);
        public IHM()
        {
            //listeComptes = new List<Compte>();
            pileChaine = new Pile<string>(4);
            pileEntier = new Pile<int>(4);
            pilePersonne = new Pile<Personne>(4);

        }



        public void Start()
        {

            pileChaine.Empiler("a");
            pileChaine.Empiler("b");
            pileChaine.Empiler("c");
            pileChaine.Empiler("d");


            pileEntier.Empiler(1);
            pileEntier.Empiler(2);
            pileEntier.Empiler(3);
            pileEntier.Empiler(4);


            pilePersonne.Empiler(new Personne("Inan", "Aguit", 36));
            pilePersonne.Empiler(new Personne("Yagami", "Iori", 25));
            pilePersonne.Empiler(new Personne("Kusanagi", "Kyo", 23));
            pilePersonne.Empiler(new Personne("Kusanagi", "Saisyu", 55));

            string choix;
            do
            {
                MenuPrincipal();
                Console.Write("Votre choix : ");
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        ActionEmpiler();
                        break;
                    case "2":
                        ActionDepiler();
                        break;
                    case "3":
                        ActionGet();
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
            //Console.Clear();
            Console.WriteLine("=== Menu principal ===");
            Console.WriteLine("1. Empiler");
            Console.WriteLine("2. Dépiler");
            Console.WriteLine("3. Récupérer à X");
            Console.WriteLine("0. Quitter\n");
        }

        private void ActionEmpiler()
        {
            Console.Clear();

            //Console.WriteLine("---Information du client");
            //Console.Write("Merci de saisir le nom : ");

            Console.Write("Valeur à empiler : ");
            int entier = Convert.ToInt32(Console.ReadLine());
            pileEntier.Empiler(entier);

        }

        private void ActionDepiler()
        {
            Console.Clear();
            pileEntier.Depiler();

        }

        private void ActionGet()
        {
            Console.Clear();
            Console.Write("Veuillez donner un indice : ");
            int entier = Convert.ToInt32(Console.ReadLine());
            pileEntier.Get(entier);

        }
    }
}
