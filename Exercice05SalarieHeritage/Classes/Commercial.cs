using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05SalarieHeritage.Classes
{
    class Commercial : Salarie
    {
        decimal chiffreAffaire;
        int commission;

        public Commercial(string matricule, string categorie, string service, string nom, decimal salaire, decimal chiffreAffaire, int commission) : base(matricule, categorie, service, nom, salaire)
        {
            this.chiffreAffaire = chiffreAffaire;
            this.commission = commission;
        }

        
    }
}
