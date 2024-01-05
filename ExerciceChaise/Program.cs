using ExerciceChaise.Classes;

// Utilisations de constructeurs (instanciations)

Chaise maChaise1 = new Chaise();
Chaise maChaise2 = new Chaise(5, "Métal", "Blanche");
Chaise maChaise3 = new Chaise(2, "Carton", "Jaune");


Console.WriteLine("---------------------");

maChaise1.Afficher();
maChaise2.Afficher();
maChaise3.Afficher();

Console.WriteLine("---------------------");

void AfficherChaises(IEnumerable<Chaise> ensembleDeChaises)
{
    Console.WriteLine("Liste des chaises :");
    foreach (Chaise chaise in ensembleDeChaises)
    {
        Console.WriteLine(chaise.ToString());
    }
}

List<Chaise> listeDeChaises = new List<Chaise>
        {
            new Chaise(10, "Bois", "Rouge"),
            new Chaise(15, "Métal", "Bleue"),
            new Chaise(12,"Carton", "Verte"),
        };


AfficherChaises(listeDeChaises);
Console.WriteLine(maChaise1);