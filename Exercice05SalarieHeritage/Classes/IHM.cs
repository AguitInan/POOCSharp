using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05SalarieHeritage.Classes
{
    class IHM
    {
        private Salarie[] employes;
        private int maxEmployes = 20;
        private int compteurEmployes = 0;


        public IHM()
        {
            employes = new Salarie[maxEmployes];
        }

        public void Start()
        {
            string choix = "";
            do
            {
                bool valid = false;
                Console.WriteLine("========== Gestion des employés =========");
                MenuPrincipal();
                Console.Write("Entrez votre choix : ");
                choix = Console.ReadLine();
                while (valid)
                {
                    if (choix == "1" && choix == "2" && choix == "3" && choix == "0")
                        valid = true;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Erreur de saisie, entrez votre choix : ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                switch (choix)
                {
                    case "1":
                        Console.Clear();
                        CreationEmploye();
                        break;
                    case "2":
                        Console.Clear();
                        SalaireEmployes();
                        break;
                    case "3":
                        Console.Clear();
                        RechercheEmploye();
                        break;
                    case "0":
                        break;
                }



            } while (choix != "0");
        }
        private void MenuPrincipal()
        {
            Console.WriteLine("1-- Ajouter un employé");
            Console.WriteLine("2-- Afficher le salaire des employés");
            Console.WriteLine("3-- Rechercher un employé");
            Console.WriteLine("0-- Quitter\n");
        }

        private void MenuCreationEmploye()
        {
            Console.WriteLine("====== Ajoué un employé ======");
            Console.WriteLine("1-- Salarié");
            Console.WriteLine("2-- Commercial");
            Console.WriteLine("0-- Retour\n");
        }

        private void CreationEmploye()
        {
            bool valid = false;
            MenuCreationEmploye();
            Console.Write("Entrer votre choix : ");
            string choix = Console.ReadLine();
            while (valid)
            {
                if (choix == "1" && choix == "2" && choix == "0")
                    valid = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Erreur de saisie, entrez votre choix : ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Salarie s = null;
            switch (choix)
            {
                case "1":
                    s = CreationSalarie();
                    break;
                case "2":
                    s = CreationCommercial();
                    break;
                case "0":
                    break;
            }
            if (s != null)
            {
                employes[compteurEmployes] = s;
                compteurEmployes++;
            }
            Console.Clear();
        }

        
    }
}

