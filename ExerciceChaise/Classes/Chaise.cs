using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceChaise.Classes
{
    internal class Chaise
    {
        // Attributs
        private int _nbPieds;
        private string _materiau;
        private string _couleur;

        // Propriétés
        public int NbPieds
        {
            get => _nbPieds;
            set => _nbPieds = value;
        }
        public string Materiau { get => _materiau; set => _materiau = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }


        // Constructeurs (crée une nouvelle instance de Chaise)

        public Chaise() //constructeur par défaut, il est vide, si on ne le crée pas, c# le crée implicitement
        {
            NbPieds = 4;
            Materiau = "Bois";
            Couleur = "Marron";
        }

        public Chaise(int nbPieds, string materiau, string couleur) // ici on a des paramètres d'entrées du constructeur
        {
            NbPieds = nbPieds;
            Materiau = materiau;
            Couleur = couleur;
        }

        // Méthodes
        public void Afficher()
        {
            Console.WriteLine($"Je suis une Chaise, avec {this.NbPieds} pieds en {Materiau} et de couleur {Couleur}");
        }

        public override string ToString()
        {
            return $"Je suis une Chaise, avec {NbPieds} pieds en {Materiau} et de couleur {Couleur}";
        }
    }

}

