// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summa(int M, int N)
{
    int sum = 0;
    while (true)
    {
        sum+=M;
        M++;
        if (M-1==N)
        break;
    }
    return sum;
}

int SummaRec(int M, int N)
{
    if (M==N)  return M;
    return M + SummaRec(M + 1, N);
}




Console.Clear();
System.Console.WriteLine("Введите целое число 'M': ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число 'N'': ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма всех натуральных чисел от {M} до {N} равна {Summa(M,N)}");
System.Console.WriteLine($"а если рекурсией то {SummaRec(M, N)}");