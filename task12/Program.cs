/*
Напишите программу, котороя 
1. будет принимать на вход два числа и 
2. выводить, является ли первое число кратным второму.
3. Если первое число не кратно второму, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

int GetIntNumber(string req)
{
    Console.WriteLine(req);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("*** ПРОВЕРЯЕТ КРАТНОСТЬ ПЕРВОГО ЧИСЛА ВТОРОМУ ***");
int numberOne = GetIntNumber("Введите число 1:");
int numberTwo = GetIntNumber("Введите число 2:");
int remainder = numberOne % numberTwo;
string message = Convert.ToBoolean(remainder) ? $"не кратно, остаток {remainder}" : "кратно";
Console.WriteLine($"{numberOne}, {numberTwo} -> {message}");