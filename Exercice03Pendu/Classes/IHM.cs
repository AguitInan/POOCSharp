using Exercice03Pendu.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03Pendu.Classes
{
    class IHM
    {
        public static void Start()
        {
            char lettre;
            bool ok = false;
            string reponse = "";

            GenerateurDeMot mot = new GenerateurDeMot();
            Pendu pendu = new Pendu(mot);

            
        }
    }
}
