using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercice02Salarie.Classes
{
    class Salarie
    {
        private string _matricule;
        private string _categorie;
        private string _service;
        private string _nom = "Salarié par défaut";
        private double _salaire = 16236;
        private static int _compteur = 0;
        private static double _salaireTotal = 0;
        //private static double _moyenneSalaire = 0;

        public Salarie()
        {
            _compteur++;
        }

        public Salarie(string matricule, string categorie, string service, string nom, double salaire) : this()
        {
            _matricule = matricule;
            _categorie = categorie;
            _service = service;
            _nom = nom;
            _salaire = salaire;
            _salaireTotal += salaire;
            //_moyenneSalaire += _salaireTotal / _compteur;
        }

        public string Matricule { get => _matricule; set => _matricule = value; }
        public string Categorie { get => _categorie; set => _categorie = value; }
        public string Service { get => _service; set => _service = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public double Salaire { get => _salaire; set => _salaire = value; }
        public static int Compteur { get => _compteur; }
        public static double SalaireTotal { get => _salaireTotal; }
        public static double MoyenneSalaire { get => _salaireTotal / _compteur; }

        public void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire fixe de {_nom} est de {_salaire} euros ");
        }

        public static void RemiseAZero()
        {
            _compteur = 0;
            _salaireTotal = 0;
        }
    }
}
