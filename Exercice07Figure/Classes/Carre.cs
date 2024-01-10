using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal class Carre : Figure
    {
        private double _cote;
        private Point _pointA;
        private Point _pointB;
        private Point _pointC;
        private Point _pointD;

        public double Cote { get => _cote; set => _cote = value; }
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
            return "Longueur de côté du carré : " + _cote;
        }
    }
}
