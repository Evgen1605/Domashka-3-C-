// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine()!); // num = 12345
// int a1 = num / 10000; // a1 = 1 т.к мы отбрасываем последние 4 цифры
// num -= a1 * 10000; // в num записываем 2345 <=> num = num % 1000 (2345)
// int a2 = num / 1000; // уже от 2345 отбрасываем ри последнии цифры и a2 = 2
// num -= a2 * 1000; // в num записываем 345
// int a3 = num / 100; // c = 3
// num -= a3 * 100; //  num = 45
// int a4 = num / 10; // d = 4
// int a5 = num % 10; // e = 5

// if (a1 == a5 && a2 == a4)
// {
//   Console.Write($"Да");
// }
// else
// {
//   Console.Write($"Нет");
// }

// решаем через массив
string num = Console.ReadLine()!;
int palindr = num.Length;

if (palindr == 5)
{
  if (num[0] == num[4] && num[1] == num[3] )
  {
    Console.Write("Да");
  }else
  {
    Console.Write("Нет");
  }
}else
{
  Console.Write("Неверное число");
}


// универсальное решение для всех чисел
// int Revers(int num){
//   int revers = 0;
//   while (num > 0)
//   {
//     revers = revers * 10 + num % 10;
//     num /= 10;
//   }
//   return revers;
// }
// if (num == Revers(num))
// {
//   Console.Write($"Да");
// }else
// {
//   Console.Write($"Нет");
// }