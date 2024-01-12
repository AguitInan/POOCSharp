﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09Hotel.Classes
{
    internal class Hotel
    {
        private List<Client> _clients;
        private List<Chambre> _chambres;
        private List<Reservation> _reservations;

        internal List<Client> Clients { get => _clients; set => _clients = value; }
        internal List<Chambre> Chambres { get => _chambres; set => _chambres = value; }
        internal List<Reservation> Reservations { get => _reservations; set => _reservations = value; }

        public Hotel(List<Client> clients, List<Chambre> chambres, List<Reservation> reservations)
        {
            _clients = clients;
            _chambres = chambres;
            _reservations = reservations;
        }
    }
}