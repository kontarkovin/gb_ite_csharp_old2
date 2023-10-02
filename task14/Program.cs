/*
Напишите программу, которая 
1. принимает на вход число и 
2. проверяет, кратно ли оно одновременно 7 и 23
3. выводит результат проверки

Например:
14 -> нет
46 -> нет
161 -> да
*/

bool IsMultiple(int num, int numOne, int numTwo)
// Проверяет кратность числа <num> одновременно <numOne> и <numTwo>
{
    return (num % (numOne * numTwo) == 0);
}

Console.WriteLine();
Console.WriteLine("*** ПРОВЕРЯЕТ КРАТНОСТЬ ЧИСЛА ОДНОВРЕМЕННО 7 и 23 ***");
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string message = IsMultiple(number, 7, 23) ? "да" : "нет";
Console.WriteLine($"{number} -> {message}");