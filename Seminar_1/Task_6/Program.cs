﻿/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) {
    Console.WriteLine("Да. Число " + number + " является чётным.");
}

else  {
    Console.WriteLine("Нет. Число " + number + " является нечётным.");
}