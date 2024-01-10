using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal class Triangle : Figure
    {
        private double _base;
        private double _hauteur;
        private Point _pointA;
        private Point _pointB;
        private Point _pointC;

        public double Base { get => _base; set => _base = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }
        internal Point PointA { get => _pointA; set => _pointA = value; }
        internal Point PointB { get => _pointB; set => _pointB = value; }
        internal Point PointC { get => _pointC; set => _pointC = value; }

        public bool Deplacement(double x, double y)
        {
            return true;
        }

        public override string ToString()
        {
            return "Base du triangle: " + _base + "\n" +
                "Hauteur du triangle : " + _hauteur;
        }
    }
}
