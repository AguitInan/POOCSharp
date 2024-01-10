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

        public Carre(Point origine, double cote) : base(origine)
        {
            _cote = cote;
        }

        public double Cote { get => _cote; set => _cote = value; }

        public bool Deplacement(double x, double y)
        {
            Console.WriteLine("Déplacement du carré par ("+x+ ","+y+") \n");

            Console.WriteLine("Coordonnées du carré ABCD (Côté = " + _cote + ") :" + "\n" +
                "A = " + ((Origine.PosX - _cote / 2) + x) + ";" + ((Origine.PosY + _cote / 2) + y) + "\n" +
                "B = " + ((Origine.PosX + _cote / 2) + x) + ";" + ((Origine.PosY + _cote / 2) + y) + "\n" +
                "C = " + ((Origine.PosX + _cote / 2) + x) + ";" + ((Origine.PosY - _cote / 2) + y) + "\n" +
                "D = " + ((Origine.PosX - _cote / 2) + x) + ";" + ((Origine.PosY - _cote / 2) + y));

            Origine.PosX += x;
            Origine.PosY += y;

            return true;
        }

        public override string ToString()
        {
            return "Coordonnées du carré ABCD (Côté = " + _cote + ") :" + "\n" +
                "A = " + (Origine.PosX - _cote/2) +";" + (Origine.PosY + _cote / 2) + "\n" +
                "B = " + (Origine.PosX + _cote / 2) + ";" + (Origine.PosY + _cote / 2) + "\n" +
                "C = " + (Origine.PosX + _cote / 2) + ";" + (Origine.PosY - _cote / 2) + "\n" +
                "D = " + (Origine.PosX - _cote / 2) + ";" + (Origine.PosY - _cote / 2);

        }
    }
}
