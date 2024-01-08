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

            do
            {
                while (!ok)
                {
                    Console.Write("Combiens d'essais souhaitez-vous ? : ");
                    if (int.TryParse(Console.ReadLine(), out int nb))
                    {
                        pendu = new Pendu(mot, nb);
                        ok = true;
                        Console.Clear();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tErreur de saisie, merci de rentrer un nombre/Chiffre");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                while (pendu.NbEssai > 0)
                {
                    // Information Utilisateur
                    Console.WriteLine("------ Le jeu du Pendu ------");
                    Console.WriteLine("Le mot à trouver est : {0}", pendu.Masque);
                    Console.WriteLine("Il vous reste {0} essai(s)", pendu.NbEssai);
                    Console.Write("Veuillez saisir une lettre : ");
                    // Récupération de la saisie Utilisateur
                    lettre = Convert.ToChar(Console.ReadLine().ToLower());
                    // Envoie de la saisie de l'utilisateur à TestChar() et en récupère la réponse
                    if (pendu.TestChar(lettre))
                        Console.WriteLine("Bravo vous avez trouvé une lettre");
                    else
                        Console.WriteLine("Et non...");
                    
                }
            } while (reponse != "NON");
        }
    }
}
