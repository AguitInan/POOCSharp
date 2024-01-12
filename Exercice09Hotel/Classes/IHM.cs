using Exercice09Hotel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09Hotel.Classes
{
    internal class IHM
    {
        Hotel hotel;

        public void Start()
        {

            Console.Write("Quel est le nom de l'hotel : ");
            string nom = Console.ReadLine();
            hotel = new Hotel(nom);
            MenuPrincipal();


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
            Console.WriteLine("--- Menu principal ---");
            Console.WriteLine("1. Ajouter un client");
            Console.WriteLine("2. Afficher la liste des clients");
            Console.WriteLine("3. Afficher les réservations d'un client");
            Console.WriteLine("4. Ajouter une réservation");
            Console.WriteLine("5. Annuler une réservation");
            Console.WriteLine("6. Afficher la liste des réservations");
            Console.WriteLine("0-- Quitter\n");
        }


        private void ActionAjoutClient()
        {
            Console.Write("Quel est le nom du client : ");
            string nom = Console.ReadLine();
            Console.Write("Quel est le prénom du client : ");
            string prenom = Console.ReadLine();
            Console.Write("Quel est le téléphone du client : ");
            string telephone = Console.ReadLine();
            Client client = new Client(nom, prenom, telephone);
            Console.WriteLine("Le client sauvegardé avec le numéro : " + client.Id);

            RetourMenu();
        }

        private void ActionAfficherListeClients()
        {
            foreach (Client c in hotel.Clients)
            {
                Console.WriteLine(c);
            }
        }


        private void ActionAfficherReservationClient()
        {
            
        }

        private void ActionAjouterReservation()
        {
            
        }



        private void ActionAnnulerReservation()
        {
            
        }


        private void ActionAfficherListeReservations()
        {
            
        }

        private void RetourMenu()
        {
           
        }

    }
}

