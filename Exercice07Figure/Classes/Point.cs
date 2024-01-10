using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal class Point
    {
        private double _posX;
        private double _posY;


        public Point(double posX, double posY)
        {
            _posX = posX;
            _posY = posY;
        }

        public double PosX { get => _posX; set => _posX = value; }
        public double PosY { get => _posY; set => _posY = value; }

        public override string ToString()
        {
            return "Position X : " + PosX + "\n" +
                "Position Y : " + PosY;
        }
    }
}
