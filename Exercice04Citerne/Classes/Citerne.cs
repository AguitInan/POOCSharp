using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice04Citerne.Classes
{
    internal class Citerne
    {
        private double _poidsAVide;
        private double _capacite;
        private double _eau;
        private double _niveauRemplissage;

        public Citerne()
        {
            
        }

        public Citerne(double poidsAVide, double capacite,double eau) : this()
        {
            PoidsAVide = poidsAVide;
            Capacite = capacite;
            Eau = eau;
            NiveauRemplissage = capacite / eau * 100;
        }

        public double PoidsAVide { get => _poidsAVide; set => _poidsAVide = value; }
        public double Capacite { get => _capacite; set => _capacite = value; }
        public double Eau { get => _eau; set => _eau = value; }
        public double NiveauRemplissage { get => _niveauRemplissage; set => _niveauRemplissage = value; }


        public void PoidsTotal()
        {
            Console.WriteLine($"Le poids total est de {_poidsAVide + (_capacite * _niveauRemplissage)} kg");
            //_poidsTotal = _poidsAVide + (_capacite * _niveauRemplissage);
        }
        public void Remplir(double volume)
        {
            _eau += volume ;
        }
        public void Vider(double volume)
        {
            _eau -= volume  ;
        }
    }
}
