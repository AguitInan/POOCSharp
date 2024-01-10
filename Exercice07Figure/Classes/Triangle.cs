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

        public Triangle(Point origine, double baseT, double hauteur) : base(origine)
        {
            _base = baseT;
            _hauteur = hauteur;
        }

        public double Base { get => _base; set => _base = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }

        public bool Deplacement(double x, double y)
        {
            Console.WriteLine("Déplacement du triangle par (" + x + "," + y + ") \n");

            Console.WriteLine("Coordonnées du triangle ABC (Base = " + _base + ", Hauteur = " + _hauteur + ") :" + "\n" +
                "A = " + (Origine.PosX + x) + ";" + ((Origine.PosY + _hauteur / 2) + y) + "\n" +
                "B = " + ((Origine.PosX + _base / 2) + x) + ";" + ((Origine.PosY - _hauteur / 2) + y) + "\n" +
                "C = " + ((Origine.PosX - _base / 2) + x) + ";" + ((Origine.PosY - _hauteur / 2) + y));

            Origine.PosX += x;
            Origine.PosY += y;

            return true;
        }

        public override string ToString()
        {
            return "Coordonnées du triangle ABC (Base = " + _base + ", Hauteur = " + _hauteur + ") :" + "\n" +
                "A = " + Origine.PosX + ";" + (Origine.PosY + _hauteur / 2) + "\n" +
                "B = " + (Origine.PosX + _base / 2) + ";" + (Origine.PosY - _hauteur / 2) + "\n" +
                "C = " + (Origine.PosX - _base / 2) + ";" + (Origine.PosY - _hauteur / 2);
        }
    }
}
