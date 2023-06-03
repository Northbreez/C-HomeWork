// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого 
//числа.
// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123


 Console.WriteLine("Введите любое число ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num < 100) || (num > 999))
    Console.WriteLine("Нет");
else
{
int x1 = num / 100;
int x2 = num % 10;
Console.WriteLine($"{x1}{x2}");
}