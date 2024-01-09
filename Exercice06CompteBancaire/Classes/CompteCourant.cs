using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal class CompteCourant : Compte
    {
        public CompteCourant(Client c, int t, decimal s = 0) : base(c, s)
        {

        }
    }
}
