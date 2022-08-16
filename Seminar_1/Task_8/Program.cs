/*
Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.
*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введённое Вами число: " + N );

int index = 1;

while (index <= N)
{
    if (index % 2 == 0) {
        Console.WriteLine( index );
    }
    
    index += 1;
}
