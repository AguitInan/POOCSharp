using Exercice07Figure.Classes;

//Carre carre = new();
//carre.Cote = 2;
//carre.Origine.PosX = 3;
//carre.Origine.PosY = 3;

//Console.WriteLine(carre);

Carre carre2 = new Carre(new Point(3,3), 2);
Console.WriteLine(carre2);
carre2.Deplacement(1, 3);


//Rectangle rectangle = new();
//rectangle.Longueur = 3;
//rectangle.Largeur = 5;
//rectangle.Origine.PosX = 3;
//rectangle.Origine.PosY = 2.5;
//Console.WriteLine(rectangle);
//rectangle.Deplacement(1, 3);
//Console.WriteLine(rectangle);


Rectangle rectangle = new Rectangle(new Point(3, 2.5), 3, 5);
Console.WriteLine(rectangle);
rectangle.Deplacement(1, 3);


//Triangle triangle = new();
//triangle.Base = 4;
//triangle.Hauteur = 5;
//triangle.Origine.PosX = 2;
//triangle.Origine.PosY = 1.5;
//Console.WriteLine(triangle);
//triangle.Deplacement(1, 3);
//Console.WriteLine(triangle);

Triangle triangle = new Triangle(new Point(2, 1.5), 4, 5);
Console.WriteLine(triangle);
triangle.Deplacement(1, 3);
