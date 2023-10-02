/*
Напишите программу, которая 
1. принимает на вход трёхзначное число и 
2. на выходе показывает вторую цифру этого числа.

Например:
456 -> 5
782 -> 8
918 -> 1
*/


int GetIntNumber(string req)
{
    Console.WriteLine(req);
    return Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine();
Console.WriteLine("*** ПОКАЗЫВАЕТ ВТОРУЮ ЦИФРУ ЧИСЛА ***");
int num = GetIntNumber("Введите трёхзначное целое число:");
string secondDigit = (num > 99) & (num < 1000) ? Convert.ToString(num % 100 / 10) : "не является трёхзначным";
Console.WriteLine($"{num} -> {secondDigit}");