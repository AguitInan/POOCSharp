using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice08Pile.Classes
{
    internal class Personne
    {
        private string _nom;
        private string _prenom;
        private int _age;

        public Personne(string nom, string prenom, int age)
        {
            _nom = nom;
            _prenom = prenom;
            _age = age;
        }

        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public int Age { get => _age; set => _age = value; }


        public override string ToString()
        {
            return $"Nom: {_nom}, Prénom: {_prenom}, Âge: {_age}";
        }

    }
}
