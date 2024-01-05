using Exercice02Salarie.Classes;


class Program
{
    static void Main(string[] args)
    {
        double totalSalaire = 0;

        //Salarie s1 = new Salarie();
        //s1.Nom = "Aguit";
        //s1.Categorie = "Cat1";
        //s1.Matricule = "Mat1";
        //s1.Service = "Serv1";
        //s1.Salaire = 1500;

        Console.WriteLine("Nombre de salariés : {0}", Salarie.Compteur);

        Salarie.RemiseAZero();
        Salarie s1 = new Salarie("Mat1", "Cat1", "Serv1", "Aguit", 1500);
        Salarie s2 = new Salarie("Mat2", "Cat2", "Serv2", "Paul", 3700);

        Salarie[] tab = new Salarie[] { s1, s2 };

        foreach (Salarie s in tab)
        {
            s.AfficherSalaire();
            totalSalaire += s.Salaire;
        }
        Console.WriteLine("Salaire total : {0}", totalSalaire);
        Console.WriteLine("Nombre de salariés : {0}", Salarie.Compteur);

        Console.WriteLine("Salaire total : {0}", Salarie.SalaireTotal);
        Console.WriteLine("Le salaire moyen est de {0}", Salarie.MoyenneSalaire);

    }
}