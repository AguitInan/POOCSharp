using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03Pendu.Classes
{
    class GenerateurDeMot
    {
        private string[] mots = new string[] { "tekken", "streetfighter", "kingoffighters", "virtuafighter", "guiltygear", "fatalfury" };

        public string Generer()
        {
            Random r = new Random();
            int randomIndex = r.Next(mots.Length);
            return mots[randomIndex];
        }
    }
}
