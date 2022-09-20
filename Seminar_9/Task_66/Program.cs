/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Vvvedite pervoje chislo: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvvedite vtoroje chislo: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{SumOfNumbers(m, n)}");

int SumOfNumbers(int start, int end)
{
    int sum = 0;
    if (start == end) return sum += start;
    return (sum += start + SumOfNumbers(start +1, end)) ;
}
