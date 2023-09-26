/*
Напишите программу, которая 
1. на входе принимает трёхзначное число и 
2. на выходе показывает последнюю цифру этого числа

Например:
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine();
Console.WriteLine("*** ПОКАЗЫВАЕТ ПОСЛЕДНЮЮ ЦИФРУ ЧИСЛА ***");
Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = -num;
}
if ((100 <= num) && (num <= 999))
{
    Console.WriteLine($"{num} -> {num % 10}");
}
else
{
    Console.WriteLine("Число не является трёхзначным!");
}