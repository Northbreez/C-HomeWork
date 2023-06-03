// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Stepen(double A, double B)
{
    double stp;
    stp = Convert.ToDouble(Math.Pow(A, B));
    return stp;
}

Console.Clear();
System.Console.WriteLine("Введите число 'A'");
double A = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число 'B'");
double B = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Возведенное число {A} в степень {B} равно - {Stepen(A, B)}");