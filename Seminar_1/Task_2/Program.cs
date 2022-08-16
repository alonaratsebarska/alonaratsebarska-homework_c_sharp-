
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
*/

Console.Write("Введите первое число: ");
int FirstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int SecondNum = Convert.ToInt32(Console.ReadLine());


if (FirstNum > SecondNum) {
    Console.WriteLine("Большим числом является " + FirstNum + ".");
    Console.WriteLine("Меньшим числом является " + SecondNum + ".");
}

else {
    Console.WriteLine("Большим числом является " + SecondNum + ".");
    Console.WriteLine("Меньшим числом является " + FirstNum + ".");
}


