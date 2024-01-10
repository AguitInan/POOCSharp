using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Exercice07Figure.Classes
{
    internal class Triangle : Figure
    {
        private double _base;
        private double _hauteur;

        public double Base { get => _base; set => _base = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }

        public bool Deplacement(double x, double y)
        {
            Console.WriteLine("Déplacement du triangle par (" + x + "," + y + ")");


            return true;
        }

        public override string ToString()
        {
            return "Coordonnées du triangle ABC (Base = " + _base + ", Hauteur = " + _hauteur + ")" + "\n" +
    "A =" + Origine.PosX + ";" + Origine.PosX +
    "B =" + Origine.PosX + ";" + Origine.PosX +
    "C =" + Origine.PosX + ";" + Origine.PosX;
        }
    }
}
