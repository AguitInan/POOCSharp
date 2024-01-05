using Exercice02Salarie.Classes;


class Program
{
    static void Main(string[] args)
    {
        decimal totalSalaire = 0;

        Salarie s1 = new Salarie();
        s1.Nom = "Aguit";
        s1.Categorie = "Cat1";
        s1.Matricule = "Mat1";
        s1.Service = "Serv1";
        s1.Salaire = 1500;

        Salarie s2 = new Salarie("Jean");
        s2.Categorie = "Cat2";
        s2.Matricule = "Mat2";
        s2.Service = "Serv2";
        s2.Salaire = 2500;

        Salarie s3 = new Salarie("Mat3", "Cat3", "Serv3", "Jacques", 3000);

        // Affichage du Compteur
        Console.WriteLine("Le nombre de salariés est de : {0}", Salarie.Compteur);
        // Reset Compteur à 0
        Salarie.ResetCompteur();
        Salarie s4 = new Salarie("Mat4", "Cat4", "Serv4", "Paul", 3700);

        // Création d'un tableau de 4 Salarié
        Salarie[] tab = new Salarie[] { s1, s2, s3, s4 };

        foreach (Salarie s in tab)
        {
            s.AfficherSalaire();
            totalSalaire += s.Salaire;
        }
        Console.WriteLine("Le montant total des salaires mensuel est de {0}", totalSalaire);
        Console.WriteLine("Le nombre de salariés est de : {0}", Salarie.Compteur);


        Console.Read();
    }
}