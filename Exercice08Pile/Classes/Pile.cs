using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice08Pile.Classes
{
    internal class Pile<T>
    {
        T[] _elements;
        int _taille;
        int _compteur = 0;

        public Pile(int t)
        {
            _taille = t;
            _elements = new T[_taille];
        }

        public void Empliler(T element)
        {
            if (_compteur < _taille)
            {
                _elements[_compteur] = element;
                _compteur++;
            }
        }

        public void Deplier()
        {
            if (_compteur > 0)
            {
                Console.WriteLine("Je dépile le dernier élément...");
                _elements[_compteur - 1] = default(T);
                _compteur--;
            }

        }
        public T Get(int index)
        {
            return _elements[index];
        }

    }
}

    