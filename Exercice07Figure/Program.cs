using Exercice07Figure.Classes;

Carre carre = new();
carre.Cote = 2;
carre.Origine.PosX = 3;
carre.Origine.PosY = 3;
Console.WriteLine(carre);
carre.Deplacement(1,3);
//Console.WriteLine(carre);


Rectangle rectangle = new();
rectangle.Longueur = 3;
rectangle.Largeur = 5;
rectangle.Origine.PosX = 3;
rectangle.Origine.PosY = 2.5;
Console.WriteLine(rectangle);
rectangle.Deplacement(1, 3);
//Console.WriteLine(rectangle);


Triangle triangle = new();
triangle.Base = 4;
triangle.Hauteur = 5;
triangle.Origine.PosX = 2;
triangle.Origine.PosY = 1.5;
Console.WriteLine(triangle);
triangle.Deplacement(1, 3);
//Console.WriteLine(triangle);
