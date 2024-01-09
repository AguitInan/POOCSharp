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

        public decimal ChiffreAffaire { get => chiffreAffaire; set => chiffreAffaire = value; }
        public int Commission { get => commission; set => commission = value; }

        public override void CalculerSalaire()
        {
            Console.WriteLine("Le salaire fixe de " + Nom + " est de " + Salaire + " euros");
            decimal salaireReel = Salaire + ChiffreAffaire * Commission / 100;
            Console.WriteLine("Le salaire avec commission de {0} est de {1} euros.", Nom, salaireReel);
        }

        public void AfficherCommercial()
        {
            Console.WriteLine("Je suis un commercial");
        }
    }
}
