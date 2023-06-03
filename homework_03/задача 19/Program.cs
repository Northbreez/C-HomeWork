// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int num)
{
    if (num < 99999 && num > 10000)
        if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
            Console.WriteLine("Да");
        else
            Console.WriteLine("Нет");
    else
        Console.WriteLine("Введите пятизначное число");
}

Console.Clear();
Console.WriteLine("Введите любое число ");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    Palindrom(num);
}
catch
{
    System.Console.WriteLine("Введите числовое значение");
}
