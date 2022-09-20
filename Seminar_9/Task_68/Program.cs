/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/
Console.WriteLine("Vvvedite m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvvedite n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Result: {AckermannFunction(m, n)}");

int AckermannFunction(int m, int n)
{
    
    if (m == 0) return  n + 1;
    else if (m > 0 && n == 0) return  AckermannFunction(m -1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}
