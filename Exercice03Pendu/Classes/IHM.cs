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
                    // Test Si le jeu est gagné
                    if (pendu.TestWin())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nBravo! Vous avez gagné ! ! ! \n");
                        Console.WriteLine("le mot à trouver était {0}" + Environment.NewLine, pendu.MotATrouve);
                        Console.ForegroundColor = ConsoleColor.White;
                        pendu.NbEssai = -1;
                        break;
                    }
                    Console.WriteLine("Appuyez sur Enter pour proposer une autre lettre...");
                    Console.ReadLine();
                    // Nettoyage console pour un nouvel essai
                    Console.Clear();
                }
                // Test si nombre d'essai = 0
                if (pendu.NbEssai == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vous avez perdu...\n");
                    Console.WriteLine("Le mot à trouver était : {0}" + Environment.NewLine, pendu.MotATrouve);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("Une nouvelle partie ? Oui / Non : ");
                reponse = Console.ReadLine().ToUpper();
                if (reponse == "NON")
                {
                    Console.WriteLine("A bientôt !");
                    Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
                    Console.Read();
                }
                ok = false;
                Console.Clear();
            } while (reponse != "NON");
        }
    }
}
