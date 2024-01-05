using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercice02Salarie.Classes
{
    class Salarie
    {
        private string matricule;
        private string categorie;
        private string service;
        private string nom;
        private decimal salaire;
        private static int compteur = 0;

        public Salarie()
        {
            compteur++;
        }
        public Salarie(string nom) : this()
        {
            this.nom = nom;
        }
        public Salarie(string matricule, string categorie, string service, string nom, decimal salaire) : this(nom)
        {
            this.matricule = matricule;
            this.categorie = categorie;
            this.service = service;
            this.salaire = salaire;
        }

        public string Matricule { get => matricule; set => matricule = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal Salaire { get => salaire; set => salaire = value; }
        public static int Compteur { get => compteur; }

        public void AfficherSalaire()
        {
            Console.WriteLine("Le salairee fixe de {0} est de {1} euros ", nom, salaire);
        }

        public static void ResetCompteur()
        {
            compteur = 0;
        }
    }
}
