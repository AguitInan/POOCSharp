using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Interfaces
{
    internal interface IDeplacable
    {
        // Les méthodes écrites dans une interface sont abstraites par défaut, on a pas besoin d'écrire le mot-clé abstract manuellement
        public void Deplacement(double x, double y);
    }
}
