// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void kubik(double num)
{
    double kub = 1;
    
    for (int i = 1; i <= num; i++)
    {
        kub = Convert.ToDouble(Math.Pow(num, i));
        System.Console.Write(kub + ", ");
    }
    
}
Console.Clear();
System.Console.WriteLine("Введите любое число:");
double num = Convert.ToDouble(Console.ReadLine());
kubik(num);