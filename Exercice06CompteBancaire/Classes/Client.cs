using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06CompteBancaire.Classes
{
    internal class Client
    {
        private static int _counter = 0;

        private int _id;
        private string _nom;
        private string _prenom;
        private string _telephone;
        private List<Compte> _listeCompte;

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
        public List<Compte> ListeCompte { get => _listeCompte; set => _listeCompte = value; }

        public Client()
        {

        }
        public Client(string n, string p, string t)
        {
            Nom = n;
            Prenom = p;
            Telephone = t;
        }

        public override string ToString()
        {
            return "Nom : " + Nom + "\n" +
                "Prénom : " + Prenom + "\n" +
                "Téléphone : " + Telephone + "\n";
        }
    }
}
