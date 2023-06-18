// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
//  суммой элементов: 1 строка

void FillArrayNumbers(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
            numbers[i, j] = new Random().Next(10, 50);
    }
}

void PrintArrayNumbers(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],2}   ");
        }
        System.Console.WriteLine();
    }
}

int SumLine(int[,] numbers, int i)
{
    int sum = numbers[i, 0];
    for (int j = 1; j < numbers.GetLength(1); j++)
    {
        sum += numbers[i, j];
    }
    return sum;
}


void SumRows(int[,] numbers)
{
int minSum = 1;
int sum = SumLine(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
    if (sum > SumLine(numbers, i))
    {
        sum = SumLine(numbers, i);
        minSum = i + 1;
    }
}

System.Console.WriteLine($"Минимальная сумма в строке: {minSum} = {sum}");
}


Console.Clear();
System.Console.WriteLine("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int colomn = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[row, colomn];
FillArrayNumbers(numbers);
PrintArrayNumbers(numbers);
SumRows(numbers);

