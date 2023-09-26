/*
Напишите программу, которая
1. на вход принимает одно число (N), а 
2. на выходе показывает все целые числа в промежутке -N до N.

Например:
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> "-2, -1, 0, 1, 2"
*/

Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num}  ->  \"");
for (int i = -num; i <= num; i++)
{
    Console.Write(i);
    if (i < num)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("\"");