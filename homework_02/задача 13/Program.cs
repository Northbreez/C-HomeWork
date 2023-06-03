// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число ");
int num = Convert.ToInt32(Console.ReadLine());

if  (num < 99)
    System.Console.WriteLine("третьей цифры нет");
else if  (num >= 100)
    while(num > 999)
    {
    num = num / 10;
    }
    System.Console.WriteLine(num % 10);