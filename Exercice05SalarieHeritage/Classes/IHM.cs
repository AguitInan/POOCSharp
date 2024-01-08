using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05SalarieHeritage.Classes
{
    class IHM
    {
        private Salarie[] employes;
        private int maxEmployes = 20;
        private int compteurEmployes = 0;


        public IHM()
        {
            employes = new Salarie[maxEmployes];
        }

        public void Start()
        {
            string choix = "";
            do
            {
                bool valid = false;
                Console.WriteLine("========== Gestion des employés =========");
                MenuPrincipal();
                Console.Write("Entrez votre choix : ");
                choix = Console.ReadLine();
                while (valid)
                {
                    if (choix == "1" && choix == "2" && choix == "3" && choix == "0")
                        valid = true;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Erreur de saisie, entrez votre choix : ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                switch (choix)
                {
                    case "1":
                        Console.Clear();
                        CreationEmploye();
                        break;
                    case "2":
                        Console.Clear();
                        SalaireEmployes();
                        break;
                    case "3":
                        Console.Clear();
                        RechercheEmploye();
                        break;
                    case "0":
                        break;
                }



            } while (choix != "0");
        }
        private void MenuPrincipal()
        {
            Console.WriteLine("1-- Ajouter un employé");
            Console.WriteLine("2-- Afficher le salaire des employés");
            Console.WriteLine("3-- Rechercher un employé");
            Console.WriteLine("0-- Quitter\n");
        }

        private void MenuCreationEmploye()
        {
            Console.WriteLine("====== Ajoué un employé ======");
            Console.WriteLine("1-- Salarié");
            Console.WriteLine("2-- Commercial");
            Console.WriteLine("0-- Retour\n");
        }

        private void CreationEmploye()
        {
            bool valid = false;
            MenuCreationEmploye();
            Console.Write("Entrer votre choix : ");
            string choix = Console.ReadLine();
            while (valid)
            {
                if (choix == "1" && choix == "2" && choix == "0")
                    valid = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Erreur de saisie, entrez votre choix : ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Salarie s = null;
            switch (choix)
            {
                case "1":
                    s = CreationSalarie();
                    break;
                case "2":
                    s = CreationCommercial();
                    break;
                case "0":
                    break;
            }
            if (s != null)
            {
                employes[compteurEmployes] = s;
                compteurEmployes++;
            }
            Console.Clear();
        }

        private Salarie CreationSalarie()
        {
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le matricule : ");
            string matricule = Console.ReadLine();
            Console.Write("Merci de saisir la catégorie : ");
            String categorie = Console.ReadLine();
            Console.Write("Merci de saisir le service : ");
            string service = Console.ReadLine();
            Console.Write("Merci de saisir le salaire : ");
            decimal salaire = Convert.ToDecimal(Console.ReadLine());
            return new Salarie(matricule, categorie, service, nom, salaire);
        }

        private Commercial CreationCommercial()
        {
            Salarie tmp = CreationSalarie();
            Console.Write("Merci de saisir le chiffre du commercial : ");
            decimal chiffreAffaire = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Merci de saisir la commission : ");
            int commission = Convert.ToInt32(Console.ReadLine());
            return new Commercial(tmp.Matricule, tmp.Categorie, tmp.Service, tmp.Nom, tmp.Salaire, chiffreAffaire, commission);
        }
        private void SalaireEmployes()
        {
            Console.WriteLine("====== Salaire de Employés =====");
            for (int i = 0; i < compteurEmployes; i++)
            {
                Console.WriteLine("------------");
                Console.WriteLine(employes[i].GetType());
                employes[i].ToString();

                if (employes[i] is Commercial c)
                    c.AfficherCommercial();
                employes[i].CalculerSalaire();
                Console.WriteLine("--------------");
            }
        }
        private void RechercheEmploye()
        {
            Console.WriteLine("===== Recherche Employé par nom =====");
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine();
            Salarie s = null;
            for (int i = 0; i < compteurEmployes; i++)
            {
                if (employes[i].Nom == nom)
                {
                    s = employes[i];
                    break;
                }
            }
            if (s != null)
                s.CalculerSalaire();
            else
                Console.WriteLine("Aucun employé n'a été trouvé avec ce nom...");
        }

        private int AvoirNombreEmployes()
        {
            return Salarie.Compteur;
        }
    }
}

