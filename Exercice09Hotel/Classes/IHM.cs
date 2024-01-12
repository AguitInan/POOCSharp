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
        Hotel _hotel;


        public void Start()
        {

            Console.Write("Quel est le nom de l'hotel : ");
            string nom = Console.ReadLine();
            _hotel = new Hotel(nom);
            MenuPrincipal();


            string choix = "";
            do
            {
                bool valid = false;
                Console.WriteLine("========== Gestion de l'hotel =========");
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
            Console.Clear();
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

            _hotel.Clients.Add(client);

            Console.WriteLine("Le client sauvegardé avec le numéro : " + client.Id);
            Console.WriteLine("Client ajouté avec succès ! ");

            RetourMenu();
        }

        private void ActionAfficherListeClients()
        {
            foreach (Client c in _hotel.Clients)
            {
                Console.WriteLine(c);
            }
            RetourMenu();
        }


        private void ActionAfficherReservationClient()
        {
            //ActionAfficherListeClients();
            foreach (Client c in _hotel.Clients)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("Réservations de quel client voulez-vous regarder ? Merci de saisir son id : ");
            Int32.TryParse(Console.ReadLine(), out int id);
            Client client = _hotel.RecupererClientParId(id);
            Console.WriteLine(client);
            _hotel.RecupererReservationClient(client);
            if (client.Reservations.Count == 0)
            {
                Console.WriteLine("Aucune reservation");
            }
            foreach (Reservation r in client.Reservations)
            {
                Console.WriteLine(r);
            }
            RetourMenu();
        }

        private void ActionAjouterReservation()
        {
            ActionAfficherListeClients();
            Console.WriteLine("Pour quel client voulez-vous faire la réservation ? Merci de saisir son id : ");
            Int32.TryParse(Console.ReadLine(), out int id);
            Client client = _hotel.RecupererClientParId(id);

            Reservation reservation = new Reservation() { Client = client, Statut = StatutReservation.Fini };
            client.Reservations.Add(reservation);
            Console.WriteLine("La réservation a été sauvgardée avec le numéro : " + reservation.Id);
            RetourMenu();
        }



        private void ActionAnnulerReservation()
        {
            ActionAfficherListeReservations();
            Console.WriteLine("Quelle réservation voulez-vous annuler ? Merci de saisir son id : ");
            Int32.TryParse(Console.ReadLine(), out int id);
            Reservation reservation = _hotel.RecupererReservationParId(id);
            if (reservation != null)
            {
                reservation.Statut = StatutReservation.Annulé;
                _hotel.UpdateStatutReservation();
                Console.WriteLine("La réservation a été annulée");
            }
            else
            {
                Console.WriteLine("Aucune reservation avec cet id");
            }

            RetourMenu();
        }


        private void ActionAfficherListeReservations()
        {
            foreach (Reservation r in _hotel.Reservations)
            {
                Console.WriteLine(r);
            }
        }

        private void RetourMenu()
        {
            Console.WriteLine("Appuyez sur Entrée pour retourner au menu");
            Console.ReadLine();
        }

    }
}
