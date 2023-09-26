/*
Напишите программу, которая 
1. на вход принимает два числа и 
2. проверяет, является ли первое квадратом второго
3. выводит результат

Например:
a = 25, b = 5 -> Да
a = 2, b = 10 -> Нет
а = 9, b =-3 -> Да
a = -3, b = 9 -> Нет
*/

Console.WriteLine();
Console.WriteLine("*** ПРОВЕРЯЕТ, ЯВЛЯЕТСЯ ЛИ ПЕРВОЕ ЧИСЛО КВАДРАТОМ ВТОРОГО ***");
Console.WriteLine("Введите целое число 'a':");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число 'b':");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"a = {number1}, b = {number2}");
if (number1 == number2 * number2)
{
   Console.WriteLine (" -> Да");
}
else
{
    Console.WriteLine(" -> Нет");
}