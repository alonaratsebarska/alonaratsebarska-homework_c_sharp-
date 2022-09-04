/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int TheSumOfTheDigitsInANumber(int num)
{
    int intermediateResult = num;      //  
    int amountOfDigitsInANumber = 0;   //  
    while (intermediateResult != 0)    //  Создаём цикл для поиска количества цифр в числе:
    {                                  //
        intermediateResult /= 10;      //  
        amountOfDigitsInANumber++;     //
    }
    int result = 0;
    int temporary1 = 0;
    int temporary2 = 0;
    int temporary3 = 0;
    int temporary4 = 0;
    int temporary5 = 0;
    int temporary6 = 0;
    if (num < 10) result = num;
    else if (amountOfDigitsInANumber == 2)
    {
        temporary1 = num / 10;
        temporary2 = num % 10;
        result = temporary1 + temporary2;
    }

    else if (amountOfDigitsInANumber == 3)      
    {
        temporary1 = num / 100;
        temporary2 = num % 100 / 10;
        temporary3 = num % 10;
        result = temporary1 + temporary2 + temporary3;
    }
    else if (amountOfDigitsInANumber == 4)
    {
        temporary1 = num / 1000;
        temporary2 = num % 1000 / 100;
        temporary3 = num % 100 / 10;
        temporary4 = num % 100 % 10;
        result = temporary1 + temporary2 + temporary3 + temporary4;
    }
    else if (amountOfDigitsInANumber == 5)
    {
        temporary1 = num / 10000;
        temporary2 = num % 10000 / 1000;
        temporary3 = num % 1000 / 100;
        temporary4 = num % 100 / 10;
        temporary5 = num % 100 % 10;
        result = temporary1 + temporary2 + temporary3 + temporary4 + temporary5;
    }
    else if (amountOfDigitsInANumber == 6)
    {
        temporary1 = num / 100000;
        temporary2 = num % 100000 / 10000;
        temporary3 = num % 10000 / 1000;
        temporary4 = num % 1000 / 100;
        temporary5 = num % 100 / 10;
        temporary6 = num % 100 % 10;
        result = temporary1 + temporary2 + temporary3 + temporary4 + temporary5 + temporary6;
    }
    return result;
}


Console.Write("Введите число до 1 миллиона: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(($"Суммой цифр введённого Вами числа {number} является {TheSumOfTheDigitsInANumber(number)}"));
