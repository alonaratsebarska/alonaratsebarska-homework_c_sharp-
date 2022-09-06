/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
void FillArrWithRandomNumbers(int[] array)           //Создаём метод, заполняющий массив рандомными числами
{
    int length = array.Length;

    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArr(int[] array)                           //Создаём метод, выводящий на экран все числа массива
{
    int count = array.Length;
    for (int index = 0; index < count; index++) 
    {
    if (index == 0) Console.Write($"[{array[index]},\t");  
    else if (index >  0 && index < count - 1) Console.Write($"{array[index]},\t");  
    else if (index == count - 1) Console.Write($"{array[index]}]");  
    }     
}

int arrLength = new Random().Next(10, 20);           //Генерируем случайное число, которое дальшее используем для обозначения размера  массива
//Console.WriteLine($"{arrLength}");
int[] arr =  new int[arrLength];                    //Создаём массив

FillArrWithRandomNumbers(arr);                     //Вызываем метод заполнения массива

int countOfEvenNumbers = 0;                        //Создаём переменную в которую будет добавлено число, обозначающее количество чётных чисел в массиве
for (int index = 0; index < arrLength; index++)   //Создаём цикл, находящий чётные числа в массиве и записывающий их количество в переменную выше 
{
    if(arr[index] % 2 == 0) 
    countOfEvenNumbers++;
}
PrintArr(arr);                                    //Вызываем метод, печатающий массив
Console.WriteLine($"\t->\t{countOfEvenNumbers}"); //Выводим количество чётн. чисел в массиве путём обращения к переменной
