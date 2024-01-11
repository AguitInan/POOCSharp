using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice08Pile.Classes
{
    internal class Pile<T>
    {
        T[] elements;
        int taille;
        int compteur = 0;

        public Pile(int t)
        {
            taille = t;
            elements = new T[taille];
        }

        public void Empliler(T element)
        {
            if (compteur < taille)
            {
                elements[compteur] = element;
                compteur++;
            }
        }

        public void Deplier()
        {
            if (compteur > 0)
            {
                Console.WriteLine("Je dépile le dernier élément...");
                elements[compteur - 1] = default(T);
                compteur--;
            }

        }
        public T Get(int index)
        {
            return elements[index];
        }

    }
}

    