/*
Напишите программу, которая 
1. принимает на вход три числа и 
2. выдаёт максимальное из этих чисел
3. выводит результат

Например:
2, 3, 7 -> 7
44, 5, 78  -> 78
22, 3, 9, -> 22
*/

Console.WriteLine("ВВЕДИТЕ ТРИ ЧИСЛА!");
Console.WriteLine("Число 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число 2:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число 3:");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine($"{num1}, {num2}, {num3} -> max = {max}");