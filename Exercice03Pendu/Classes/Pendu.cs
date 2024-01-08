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

        public string MotATrouve { get => motATrouve; set => motATrouve = value; }
        public int NbEssai { get => nbEssai; set => nbEssai = value; }
        public string Masque { get => masque; set => masque = value; }

        public bool TestChar(char c)
        {
            bool found = false;
            string masqueTmp = "";
            for (int i = 0; i < MotATrouve.Length; i++)
            {
                if (MotATrouve[i] == c)
                {
                    found = true;
                    masqueTmp += c;
                }
                else
                {
                    masqueTmp += masque[i];
                }
            }
            
        }

        public bool TestWin()
        {
            if (motATrouve == masque && NbEssai > 0)
            {
                return true;
            }
            return false;
        }

        public void GenererMasque()
        {
            masque = "";
            for (int i = 0; i < MotATrouve.Length; i++)
            {
                masque += "*";
            }
        }

    }
}
