﻿using Exercice09Hotel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09Hotel.Classes
{
    internal class Hotel
    {
        private string _nom;
        private List<Client> _clients;
        private List<Chambre> _chambres;
        private List<Reservation> _reservations;

        public string Nom { get => _nom; set => _nom = value; }
        internal List<Client> Clients { get => _clients; set => _clients = value; }
        internal List<Chambre> Chambres { get => _chambres; set => _chambres = value; }
        internal List<Reservation> Reservations { get => _reservations; set => _reservations = value; }

        public Hotel(List<Client> clients, List<Chambre> chambres, List<Reservation> reservations)
        {
            _clients = clients;
            _chambres = chambres;
            _reservations = reservations;
        }


        public Hotel(string n)
        {
            Nom = n;
            Clients = new List<Client>();
            Reservations = new List<Reservation>();

        }

        public Client RecupererClientParId(int id)
        {
            Client client = null;
            foreach (Client c in Clients)
            {
                if (c.Id == id)
                {
                    client = c;
                    break;
                }
            }
            return client;
        }

        public Reservation RecupererReservationParId(int id)
        {
            Reservation reservation = null;
            foreach (Reservation r in Reservations)
            {
                if (r.Id == id)
                {
                    reservation = r;
                    break;
                }
            }
            return reservation;
        }


        public void RecupererReservationClient(Client client)
        {
            foreach (Reservation r in Reservations)
            {
                if (r.Client.Id == client.Id)
                {
                    client.Reservations.Add(r);
                }
            }
        }



        public void UpdateStatutReservation()
        {
            
        }


    }
}
