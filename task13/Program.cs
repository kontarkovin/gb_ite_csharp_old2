/*
Напишите программу, которая 
1. выводит третью цифру заданного числа или 
2. сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine();
Console.WriteLine("*** ПОКАЗЫВАЕТ ТРЕТЬЮ ЦИФРУ ЗАДАННОГО ЧИСЛА ***");
int num = new Random().Next(100000);
string thirdDigit = (num > 99) ? num.ToString()[2].ToString() : "третьей цифры нет";
Console.WriteLine($"{num} -> {thirdDigit}");