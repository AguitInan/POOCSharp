using System;

namespace Exercice08Pile.Classes
{
    internal class IHM
    {
        private Pile<string> pileChaine;
        private Pile<int> pileEntier;
        private Pile<Personne> pilePersonne;

        public IHM()
        {
            pileChaine = new Pile<string>(4);
            pileEntier = new Pile<int>(4);
            pilePersonne = new Pile<Personne>(4);
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
                        ActionEmpiler();
                        break;
                    case "2":
                        ActionDepiler();
                        break;
                    case "3":
                        ActionGet();
                        break;
                    case "0":
                        // Quitter la console
                        Console.WriteLine("Fermeture de l'application...");
                        return;
                }

            } while (choix != "0");
        }

        private void MenuPrincipal()
        {
            Console.WriteLine("=== Menu principal ===");
            Console.WriteLine("1. Empiler");
            Console.WriteLine("2. Dépiler");
            Console.WriteLine("3. Récupérer à X");
            Console.WriteLine("0. Quitter\n");
        }

        private void ActionEmpiler()
        {
            Console.Clear();
            Console.Write("Valeur à empiler (entier uniquement) : ");
            if (int.TryParse(Console.ReadLine(), out int entier))
            {
                pileEntier.Empiler(entier);
                pileEntier.AfficherElements(); // Affiche l'état actuel de la pile
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez saisir un nombre entier.");
            }
        }

        private void ActionDepiler()
        {
            Console.Clear();
            pileEntier.Depiler();
            pileEntier.AfficherElements(); // Affiche l'état actuel de la pile
        }

        private void ActionGet()
        {
            Console.Clear();
            Console.Write("Veuillez donner un indice : ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                var element = pileEntier.Get(index);
                if (element != null)
                {
                    Console.WriteLine($"Élément à l'indice {index} : {element}");
                }
            }
            else
            {
                Console.WriteLine("Index invalide. Veuillez saisir un nombre entier.");
            }
        }
    }
}
