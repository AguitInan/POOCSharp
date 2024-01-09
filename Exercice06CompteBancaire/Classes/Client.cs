﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06CompteBancaire.Classes
{
    public class Client
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private string _telephone;

        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
        public int Id { get => _id; set => _id = value; }

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
