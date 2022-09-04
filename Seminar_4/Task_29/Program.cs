/*
Задача 29: Напишите программу,
которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void FillArrayWithRandomNumbers(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 1000);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        if (position == 0) Console.Write($"[{array[position]}, ");
        else if (position > 0 && position < count - 1) Console.Write($" {array[position]}, ");
        else if(position == count -1) Console.Write($" {array[position]}] ");
        position++;
    }
}


int[] arr = new int[8];
FillArrayWithRandomNumbers(arr);
PrintArray(arr);
