/*
Задача 42: Напишите программу,
которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.Write("Vvedite chislo: ");
int number = Convert.ToInt32(Console.ReadLine());
string binNumber = Convert.ToString(number,2);
 
Console.WriteLine(binNumber); //выведет - "1100"
