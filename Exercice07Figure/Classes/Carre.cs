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

        public bool Deplacement(double x, double y)
        {
            Console.WriteLine("Déplacement du carré par ("+x+ ","+y+")");



            return true;
        }

        public override string ToString()
        {
            return "Coordonnées du carré ABCD (Côté = " + _cote + ")" + "\n" +
                "A =" + (Origine.PosX - _cote/2) +";" + (Origine.PosX + _cote / 2) +
                "B =" + (Origine.PosX + _cote / 2) + ";" + (Origine.PosX + _cote / 2) +
                "C =" + (Origine.PosX + _cote / 2) + ";" + (Origine.PosX - _cote / 2) +
                "D =" + (Origine.PosX - _cote / 2) + ";" + (Origine.PosX - _cote / 2);

        }
    }
}
