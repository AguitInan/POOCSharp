using System;

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

        public void Empiler(T element)
        {
            if (_compteur < _taille)
            {
                _elements[_compteur] = element;
                _compteur++;
            }
            else
            {
                Console.WriteLine("La pile est pleine !");
            }
        }

        public void Depiler()
        {
            if (_compteur > 0)
            {
                _compteur--;
                _elements[_compteur] = default(T);
            }
            else
            {
                Console.WriteLine("La pile est déjà vide !");
            }
        }

        public T Get(int index)
        {
            if (index >= 0 && index < _compteur)
            {
                return _elements[index];
            }
            else
            {
                Console.WriteLine("Index invalide.");
                return default(T);
            }
        }

        public void AfficherElements()
        {
            Console.WriteLine("Éléments dans la pile :");
            for (int i = 0; i < _compteur; i++)
            {
                Console.WriteLine(_elements[i]);
            }
        }
    }
}
