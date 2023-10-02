/*
Напишите программу, которая 
1. выводит случайное трёхзначное число и 
2. удаляет вторую цифру этого числа.
3. выводит результат

Например:
456 -> 46
782 -> 72
918 -> 98
*/


int DeleteSecondDigit(int num)
{
    int numberOne = num / 100;
    int numberThree = num % 10;
    return numberOne * 10 + numberThree;
}


Console.WriteLine("*** УДАЛЯЕТ ВТОРУЮ ЦИФРУ ТРЁХЗНАЧНОГО ЧИСЛА ***");
int number = new Random().Next(100, 1000);
Console.WriteLine($"Cлучайное трёхзначное число -> {number}");
Console.WriteLine($"{number} -> {DeleteSecondDigit(number)}");