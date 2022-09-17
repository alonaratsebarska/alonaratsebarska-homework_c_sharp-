/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double[,] massive = new double[3, 4] { { 1, 4, 7, 2, }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

PrintArray(massive);

Console.WriteLine($"Среднее арифметическое 1 столбца: {Math.Round((massive[0, 0] + massive[1, 0] + massive[2, 0]) / massive.GetLength(0), 2)}");
Console.WriteLine($"Среднее арифметическое 2 столбца: {Math.Round((massive[0, 1] + massive[1, 1] + massive[2, 1]) / massive.GetLength(0), 2)}");
Console.WriteLine($"Среднее арифметическое 3 столбца: {Math.Round((massive[0, 2] + massive[1, 2] + massive[2, 2]) / massive.GetLength(0), 2)}");
Console.WriteLine($"Среднее арифметическое 4 столбца: {Math.Round((massive[0, 3] + massive[1, 3] + massive[2, 3]) / massive.GetLength(0), 2)}");
