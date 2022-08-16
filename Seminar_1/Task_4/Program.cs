/* Задача 4: Напишите программу, которая принимает на вход три числа 
 и выдаёт максимальное из этих чисел.
 */

 Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxnumber = number1;

if (number2 > number1) {
    maxnumber = number2;
}

if (number3 > number2) {
    maxnumber = number3;
}

Console.WriteLine("Максимальне число " + maxnumber + ".");
