/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] array = new double[10];

void FillArrayWithRandomRealNumbers(double[] arr)
{
    double temporary = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        temporary = new Random().NextDouble();
        arr[i] = Math.Round(temporary * 100, 2);
    }
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]}\t");
        else if (i > 0 && i < arr.Length - 1) Console.Write($"{arr[i]}\t");
        else if (i == arr.Length - 1) Console.Write($"{arr[i]}]");
    }
}

FillArrayWithRandomRealNumbers(array);
PrintArray(array);

double maxNumber = array[0];
double minNumber = array[0];
int size = Convert.ToInt32(array.Length);
for (int i = 0; i < size; i++)
{
    if(minNumber < array[i]) continue;
    else minNumber = array[i];
}
for (int i = 0; i < size; i++)
{
    if(maxNumber > array[i]) continue;
    else maxNumber = array[i];
}

double difference = maxNumber - minNumber;
Console.WriteLine($"\t->\t{Math.Round(difference, 2)}");
