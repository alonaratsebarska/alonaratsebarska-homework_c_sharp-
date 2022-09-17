/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine("Vvvedite kolichestvo strok: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvvedite kolichestvo stolbcov: ");
int columns = Convert.ToInt32(Console.ReadLine());

 double[,] matrix = new double[rows, columns];
void GetArray(int m, int n)
{
    //double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        //double temp = 0;
        for (int j = 0; j < n; j++)
        {
           //temp = new Random().NextDouble();
           //matrix[i, j] = Math.Round(temp * 10, 2);
           matrix[i, j] = Convert.ToDouble(new Random().Next(-10,11));
        }
    }
}

void PrintArray(double[,] array, double m, double n)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
GetArray(rows,columns);
PrintArray(matrix, rows, columns);