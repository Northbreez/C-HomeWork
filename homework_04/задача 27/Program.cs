// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
return result;
}

Console.Clear();
System.Console.WriteLine("Введите любое число:");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма цифр цисла {num} равнa - {Sum(num)}");