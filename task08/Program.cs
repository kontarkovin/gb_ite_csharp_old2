/*
Напишите программу, которая 
1. на вход принимает число (N), а 
2. на выходе показывает все чётные числа от 1 до N.

Например:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine();
Console.WriteLine("*** ПОКАЗЫВАЕТ ВСЕ ЧЁТНЫЕ ЧИСЛА ОТ 1 ДО N ***");
Console.WriteLine("Введите число N:");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> ");
for (int i = 2; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        if ((i < num) && (i + 1 != num)) Console.Write(", ");
    }
}
Console.WriteLine();