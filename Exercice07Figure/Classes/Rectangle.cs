﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal class Rectangle : Figure
    {
        private double _longueur;
        private double _largeur;

        public double Longueur { get => _longueur; set => _longueur = value; }
        public double Largeur { get => _largeur; set => _largeur = value; }
    }
}
