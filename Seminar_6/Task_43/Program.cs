﻿/*
Задача 43: Напишите программу,
которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
void FindACrossPoint(double k1, double b1, double k2, double b2)
{
    double x = Math.Round((b1 - b2) / (k2 - k1), 2);
    double y = Math.Round((k2 * b1 - k1 * b2) / (k2 - k1), 2);

    if (k1 == k2) Console.WriteLine("Priamyje ne peresekajutsa");
    else Console.WriteLine($"Tochka peresechenija prjamych: ({x}; {y})");
}

Console.Write("Vvedite b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Vvedite k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Vvedite b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Vvedite k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

FindACrossPoint(k1, b1, k2, b2);



