/*
Напишите программу, которая будет выводить название дня недели по заданному номеру

Например:
3 -> Среда
5 -> Пятница
*/

Console.WriteLine("Введите номер дня недели:");
int week_day_number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{week_day_number} -> ");
if (week_day_number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (week_day_number == 2)
{
    Console.WriteLine("Вторник");
}
else if (week_day_number == 3)
{
    Console.WriteLine("Среда");
}
else if (week_day_number == 4)
{
    Console.WriteLine("Четверг");
}
else if (week_day_number == 5)
{
    Console.WriteLine("Пятница");
}
else if (week_day_number == 6)
{
    Console.WriteLine("Суббота");
}
else if (week_day_number == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Такого дня недели нет!");
}