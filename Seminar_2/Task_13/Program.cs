/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Vvedite chislo: ");
string InputNumber = Console.ReadLine();
int length = InputNumber.Length;
if (length >= 3) {
    Console.WriteLine($"Третья цифра введённого пользователем числа: {InputNumber[2]}");
}
if (length <= 2)   {
    Console.WriteLine("Третьей цифры нет");
}