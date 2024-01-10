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
        private Point _pointA;
        private Point _pointB;
        private Point _pointC;
        private Point _pointD;

        public double Longueur { get => _longueur; set => _longueur = value; }
        public double Largeur { get => _largeur; set => _largeur = value; }
        internal Point PointA { get => _pointA; set => _pointA = value; }
        internal Point PointB { get => _pointB; set => _pointB = value; }
        internal Point PointC { get => _pointC; set => _pointC = value; }
        internal Point PointD { get => _pointD; set => _pointD = value; }

        public bool Deplacement(double x, double y)
        {
            return true;
        }

        public override string ToString()
        {
            return "Longueur du rectangle: " + _longueur + "\n" +
                "Longueur du rectangle : " + _largeur;
        }
    }
}
