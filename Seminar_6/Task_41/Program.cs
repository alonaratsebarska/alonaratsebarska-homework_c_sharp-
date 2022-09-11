/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

int CountOfPositiveNumbers(int[,] matr)
{
    int count = 0;
    for (int k = 0; k < matr.GetLength(0); k++)
    {
        for (int l = 0; l < matr.GetLength(1); l++)
        {
            if (matr[k,l] > 0) count +=1;
            else continue;
        }
    }
    return count;
}

int[,] matrix = new int[2,3];
Console.Write("Vvedite 6 chisel: ");
FillMatrix(matrix);
Console.WriteLine($"Polzovatel vvel {CountOfPositiveNumbers(matrix)} chisel bolshe 0.");