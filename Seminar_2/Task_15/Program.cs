int[] array = { 1, 2, 3, 4, 5, 6, 7 };

Console.WriteLine("Введите, какой сегодня по счёту день недели (число от одного до семи): ");
int DayOfAWeek = Convert.ToInt32(Console.ReadLine());

if (DayOfAWeek == array[5])
{
    Console.WriteLine("Да, поздравляю, сегодня выходной день недели (Суббота).");
}
if (DayOfAWeek == array[6])
{
    Console.WriteLine("Да, поздравляю, сегодня выходной день недели (Воскресенье).");
}
if (DayOfAWeek <= array[4])
{
    Console.WriteLine("Нет, сегодня будний день недели. Иди на работу / учёбу :) .");
}
