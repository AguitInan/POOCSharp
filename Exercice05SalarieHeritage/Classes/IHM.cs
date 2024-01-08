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
        
    }
}

