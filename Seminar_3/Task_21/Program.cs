/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Vvedite koordinaty po osi oX tochki A: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite koordinaty po osi oY tochki A: ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite koordinaty po osi oS tochki A: ");
int Sa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite koordinaty po osi oX tochki B: ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite koordinaty po osi oY tochki B: ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite koordinaty po osi oS tochki B: ");
int Sb = Convert.ToInt32(Console.ReadLine());

double DistanceBetweenPoints = Math.Round(Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Sb - Sa), 2)), 2);
Console.WriteLine($"Rasstojanie mezhdu dvumia kordinatnymi tochkami v 3D prostranstve: {DistanceBetweenPoints}");