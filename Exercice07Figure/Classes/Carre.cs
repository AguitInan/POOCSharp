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

        public double Cote { get => _cote; set => _cote = value; }

        public override string ToString()
        {
            return "Longueur de côté du carré : " + _cote;
        }
    }
}
