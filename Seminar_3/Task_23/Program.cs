/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Vvedite chislo:");
int number = Convert.ToInt32(Console.ReadLine());

int[] listOfNumberCubes = new int[number];

void tableOfCubes(int[] array, int num)
{
    int consecutiveNumber = 1;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Math.Pow(consecutiveNumber, 3));
        consecutiveNumber++;
    }
}

void printArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (i < count - 1) Console.Write($"{array[i]}, ");
        if (i == count - 1) Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

tableOfCubes(listOfNumberCubes, number);
printArray(listOfNumberCubes);
