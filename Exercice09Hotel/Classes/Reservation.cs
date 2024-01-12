using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice09Hotel.Classes
{
    internal class Reservation
    {
        private int _id;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private StatutReservation _statut;
        private List<Chambre> _chambres;
        private Client _client;

        public int Id { get => _id; set => _id = value; }
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public List<Chambre> Chambres { get => _chambres; set => _chambres = value; }
        public Client Client { get => _client; set => _client = value; }
        public StatutReservation Statut { get => _statut; set => _statut = value; }

        public Reservation()
        {

        }

        public override string ToString()
        {
            return "Numero : " + Id + " " +
                "Date de début : " + DateDebut + " " +
                "Date de Fin : " + DateFin + " " +
                "Satut " + Statut + "\n" +
                "Client : " + Client.ToString();
        }
    }

    enum StatutReservation
    {
        Prévu,
        EnCours,
        Fini,
        Annulé,
    }
}
