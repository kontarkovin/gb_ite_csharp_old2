/*
Напишите программу, которая 
1. выводит случайное число из отрезка [10, 99] и 
2. показывает наибольшую цифру числа.

Например:
78 -> 8
12 -> 2
85 -> 8
*/


int maxDigit(int num)
{
    int numberOne = num / 10;
    int numberTwo = num % 10;
    return numberOne > numberTwo ? numberOne : numberTwo;
}


Console.WriteLine();
Console.WriteLine("*** ПОКАЗЫВАЕТ НАИБОЛЬШУЮ ЦИФРУ ЧИСЛА ***");
int number = new Random().Next(10, 100);
Console.WriteLine($"Cлучайное число из отрезка [10, 99] -> {number}");

/*
int numberOne = number / 10;
int numberTwo = number % 10;
int max = numberOne > numberTwo ? numberOne : numberTwo;
Console.WriteLine($"{number} -> {max}");
*/

Console.WriteLine($"{number} -> {maxDigit(number)}");

