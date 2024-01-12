using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09Hotel.Classes
{
    internal class IHM
    {


        private void MenuPrincipal()
        {
            Console.WriteLine("1. Ajouter un client");
            Console.WriteLine("2. Afficher la liste des clients");
            Console.WriteLine("3. Afficher les réservations d'un client");
            Console.WriteLine("4. Ajouter une réservation");
            Console.WriteLine("5. Annuler une réservation");
            Console.WriteLine("6. Afficher la liste des réservations");
            Console.WriteLine("0-- Quitter\n");
        }


    }
}
