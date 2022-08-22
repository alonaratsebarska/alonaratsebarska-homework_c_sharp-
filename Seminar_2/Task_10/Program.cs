/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int SecondNumberOf(int number)
{
    int result = number % 100 / 10;
    return result;
}

int number = new Random().Next(100,1000);
Console.WriteLine("Рандомное число " + number); 

Console.WriteLine("Вторая цифра трёхзначного числа: " + SecondNumberOf(number));
