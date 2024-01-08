using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05SalarieHeritage.Classes
{
    class Salarie
    {
        private string matricule;
        private string categorie;
        private string service;
        private string nom;
        private decimal salaire;
        private static int compteur = 0;

        public string Matricule { get => matricule; set => matricule = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal Salaire { get => salaire; set => salaire = value; }

        public static int Compteur { get => compteur; }

        public Salarie()
        {
            // Console.WriteLine("Constructeur par défaut");
            compteur++;
        }

        // En utilisant ce constructeur, on appelle le constructeur Salarie par défaut avant
        public Salarie(string nom) : this()
        {
            this.nom = nom;
        }


        // En utilisant ce constructeur, on appelle le constructeur Salarie avec un parametre (nom) avant
        public Salarie(string matricule, string categorie, string service, string nom, decimal salaire) : this(nom)
        {
            this.matricule = matricule;
            this.categorie = categorie;
            this.service = service;
            this.Salaire = salaire;
        }

        public virtual void CalculerSalaire()
        {
            Console.WriteLine("Le salaire fixe de " + Nom + " est de " + Salaire + " euros");
        }

    }
}
