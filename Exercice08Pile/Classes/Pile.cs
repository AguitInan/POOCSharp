using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice08Pile.Classes
{
    internal class Pile
    {
    }
}

    class Pile<T>
    {
        T[] elements;
        int taille;
        int compteur = 0;

        //public event Action PilePleine;

        public Pile(int t)
        {
            taille = t;
            elements = new T[taille];
        }

        

    }