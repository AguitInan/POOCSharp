using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Exercice07Figure.Classes
{
    internal class Rectangle : Figure
    {
        private double _longueur;
        private double _largeur;

        public Rectangle(Point origine, double longueur, double largeur) : base(origine)
        {
            _longueur = longueur;
            _largeur = largeur;
        }

        public double Longueur { get => _longueur; set => _longueur = value; }
        public double Largeur { get => _largeur; set => _largeur = value; }


        public bool Deplacement(double x, double y)
        {
            Console.WriteLine("Déplacement du rectangle par (" + x + "," + y + ") \n");

            Console.WriteLine("Coordonnées du rectangle ABCD (Longueur = " + _longueur + ", Largeur = " + _largeur + ") :" + "\n" +
               "A = " + ((Origine.PosX - _longueur / 2) + x) + ";" + ((Origine.PosY + _longueur / 2) + y) + "\n" +
                "B = " + ((Origine.PosX + _longueur / 2) + x) + ";" + ((Origine.PosY + _largeur / 2) + y) + "\n" +
                "C = " + ((Origine.PosX + _longueur / 2) + x) + ";" + ((Origine.PosY - _largeur / 2) + y) + "\n" +
                "D = " + ((Origine.PosX - _longueur / 2) + x) + ";" + ((Origine.PosY - _largeur / 2) + y));

            Origine.PosX += x;
            Origine.PosY += y;

            return true;
        }

        public override string ToString()
        {
            return "Coordonnées du rectangle ABCD (Longueur = " + _longueur + ", Largeur = " + _largeur + ") :" + "\n" +
               "A = " + (Origine.PosX - _longueur / 2) + ";" + (Origine.PosY + _longueur / 2) + "\n" +
                "B = " + (Origine.PosX + _longueur / 2) + ";" + (Origine.PosY + _largeur / 2) + "\n" +
                "C = " + (Origine.PosX + _longueur / 2) + ";" + (Origine.PosY - _largeur / 2) + "\n" +
                "D = " + (Origine.PosX - _longueur / 2) + ";" + (Origine.PosY - _largeur / 2);
        }
    }
}
