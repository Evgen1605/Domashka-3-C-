// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int a = num / 10000;
int b = num % 10;

if (a == b)
{
  Console.Write($"{num} -> Да");
}
else
{
  Console.Write($"{num} -> Нет");
}
