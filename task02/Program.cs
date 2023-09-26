/*
Напишите программу, которая 
1. на вход принимает два числа и 
2. выдаёт, какое число большее, а какое меньшее
3. выводит результат

Например:
a = 5, b = 7 -> max = 7
a = 2, b = 10 -> max = 10
a = -9, b = -3 -> max = -3
*/

Console.WriteLine("Введите число 'a':");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 'b':");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"a = {number1}, b = {number2} -> max = ");
if (number1 > number2)
{
   Console.WriteLine (number1);
}
else if (number1 < number2)
{
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine($"a = b = {number1}");
}