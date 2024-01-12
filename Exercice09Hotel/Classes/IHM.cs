using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09Hotel.Classes
{
    internal class IHM
    {

        public void Start()
        {
            string choix = "";
            do
            {
                bool valid = false;
                Console.WriteLine("========== Gestion des hotels =========");
                MenuPrincipal();
                Console.Write("Votre choix : ");
                choix = Console.ReadLine();
                while (valid)
                {
                    if (choix == "1" && choix == "2" && choix == "3" && choix == "4" && choix == "5" && choix == "6" && choix == "0")
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
                        ActionAjoutClient();
                        break;
                    case "2":
                        Console.Clear();
                        ActionAfficherListeClients();
                        break;
                    case "3":
                        Console.Clear();
                        ActionAfficherReservationClient();
                        break;
                    case "4":
                        Console.Clear();
                        ActionAjouterReservation();
                        break;
                    case "5":
                        Console.Clear();
                        ActionAnnulerReservation();
                        break;
                    case "6":
                        Console.Clear();
                        ActionAfficherListeReservations();
                        break;
                    case "0":
                        break;
                }



            } while (choix != "0");
        }


        private void MenuPrincipal()
        {
            Console.WriteLine("1. Ajouter un client");
            Console.WriteLine("2. Afficher la liste des clients");
            Console.WriteLine("3. Afficher les réservations d'un client");
            Console.WriteLine("4. Ajouter une réservation");
            Console.WriteLine("5. Annuler une réservation");
            Console.WriteLine("6. Afficher la liste des réservations");
            Console.WriteLine("0-- Quitter\n");
        }


    }
}
