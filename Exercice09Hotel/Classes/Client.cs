using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Exercice09Hotel.Classes
{
    internal class Client
    {
        private int _id;

        private string _nom;

        private string _prenom;

        private string _telephone;

        private List<Reservation> _reservations;

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }

        public List<Reservation> Reservations { get => _reservations; set => _reservations = value; }

        public Client()
        {
            Reservations = new List<Reservation>();
        }
        public Client(string n, string p, string t) : this()
        {
            Nom = n;
            Prenom = p;
            Telephone = t;
        }

        public override string ToString()
        {
            return "Id : " + Id + " " +
                "Nom : " + Nom + " " +
                "Prénom : " + Prenom + " " +
                "Téléphone : " + Telephone;
        }


    }
}
