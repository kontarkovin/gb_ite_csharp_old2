/*
Напишите программу, которая 
1. принимает на вход два числа и 
2. проверяет, является ли одно число квадратом другого.
3. выводит результат

Например:
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8, 9 -> нет
*/

int GetIntNumber(string req)
{
    Console.WriteLine(req);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsSquare(int numOne, int numTwo)
{
    return (numOne == numTwo * numTwo || numTwo == numOne * numOne);
}

Console.WriteLine();
Console.WriteLine("*** ПРОВЕРЯЕТ, ЯВЛЯЕТСЯ ЛИ ОДНО ЧИСЛО КВАДРАТОМ ДРУГОГО ***");
int numberOne = GetIntNumber("Введите число 1:");
int numberTwo = GetIntNumber("Введите число 2:");
string answer = IsSquare(numberOne, numberTwo) ? "да" : "нет";
Console.WriteLine($"{numberOne}, {numberTwo} -> {answer}");