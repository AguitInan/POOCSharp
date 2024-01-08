using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03Pendu.Classes
{
    class Pendu
    {
        private GenerateurDeMot generateur;
        private string motATrouve;
        private int nbEssai;
        private string masque;

        public Pendu(GenerateurDeMot g)
        {
            generateur = g;
            MotATrouve = g.Generer();
            GenererMasque();
            nbEssai = 10;
        }
        public Pendu(GenerateurDeMot g, int n) : this(g)
        {
            nbEssai = n;
        }


    }
}
