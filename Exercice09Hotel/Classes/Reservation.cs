using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice09Hotel.Classes
{
    internal class Reservation
    {
        private int id;
        private DateTime dateDebut;
        private DateTime dateFin;
        private StatutReservation statut;

        private Client client;

        public int Id { get => id; set => id = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public Client Client { get => client; set => client = value; }
        public StatutReservation Statut { get => statut; set => statut = value; }

       
    }


}
