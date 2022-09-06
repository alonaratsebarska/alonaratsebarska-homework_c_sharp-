/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void FillArrayWithRandomNumbers(int[] array)
{
    int length = array.Length;
    int i = 0;
    while (i < length)
    {
        array[i] = new Random().Next(1, 100);
        i++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    while(index < count)
    {
        if (index == 0) Console.Write($"[{array[index]},\t");
        else if (index > 0 && index < count - 1) Console.Write($"{array[index]},\t");
        else if (index == count - 1) Console.Write($"{array[index]}]");
        index++;
    }
}

int lengthOfArray = new Random().Next(5, 20);
int[] array = new int[lengthOfArray];

FillArrayWithRandomNumbers(array);

int sumOfUnevenNumbers = 0;
for (int i = 0; i < lengthOfArray; i++)
{
    if (array[i] % 2 != 0) sumOfUnevenNumbers += array[i];
}

PrintArray(array);
Console.WriteLine($"\t->\t{sumOfUnevenNumbers}");
