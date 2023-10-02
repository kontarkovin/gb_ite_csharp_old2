/*
Напишите программу, которая 
1. принимает на вход цифру, обозначающую день недели, и 
2. проверяет, является ли этот день выходным.
3. выводит результат

6 -> да
7 -> да
1 -> нет
*/


int GetIntNumber(string req)
{
    Console.WriteLine(req);
    return Convert.ToInt32(Console.ReadLine());
}

string WeekDayAnswer(int dayNum)
{
    return (dayNum == 6 | dayNum == 7) ? "да" : (dayNum < 1 || dayNum > 7) ? "не является днём недели" : "нет";
}

Console.WriteLine();
Console.WriteLine("*** ПРОВЕРЯЕТ, ЯВЛЯЕТСЯ ЛИ ДЕНЬ НЕДЕЛИ ВЫХОДНЫМ ***");
int weekDay = GetIntNumber("Введите номер дня недели:");
Console.WriteLine($"{weekDay} -> {WeekDayAnswer(weekDay)}");