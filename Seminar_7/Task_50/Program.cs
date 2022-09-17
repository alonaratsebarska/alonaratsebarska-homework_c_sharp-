/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Write("Vvvedite poziciju elementa v stroke: ");
int firstPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvvedite poziciju elementa v stolbce: ");
int secondPosition = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[3, 4];
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

string FindElementValue(int[,] arr, int firstN, int secN)
{
    string result = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (firstN >= arr.GetLength(0) && secN >= arr.GetLength(1)) result = $"Elementa za ukazannoj poziciej  net";
            else if (firstN >= arr.GetLength(0) || secN >= arr.GetLength(1)) result = $"Elementa za ukazannoj poziciej  net";
            else result = $"Znachenijem elementa za ukazannoj poziciej  javliaetsia chislo {arr.GetValue(firstN, secN)}"; 
        }
    }
    return result;
}

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine(FindElementValue(matrix, firstPosition, secondPosition));
