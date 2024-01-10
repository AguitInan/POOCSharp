using Exercice07Figure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal abstract class Figure : IDeplacable
    {
        private Point _origine;

        public Point Origine { get => _origine; set => _origine = value; }
        protected Figure(Point origin)
        {
            _origine = origin;
        }

        public void Deplacement(double x, double y)
        {
            _origine.PosX += x;
            _origine.PosY += y;
        }

        //public bool Deplacement(double x, double y)
        //{
        //    throw new NotImplementedException();
        //}
    }
}



