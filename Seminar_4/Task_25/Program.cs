/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/
int Exponentiation(int firstNum, int degreeOfFirstNumber)
{
    int result = 0;
    for(int i = 1; i < degreeOfFirstNumber; i++)
    {
        if (i == 1) result = firstNum * firstNum;
        else if (i > 1) result = result * firstNum;
    }
    return result;
}

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int degreeOfNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результатом возведения числа {number} в {degreeOfNumber}-ю степень является число {Exponentiation(number, degreeOfNumber)}");
