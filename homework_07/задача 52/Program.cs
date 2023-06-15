// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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

void SumColomn(int[,] numbers)
{
    int sum = 0;
    int arifmetic = 0;
    int col = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
            sum += numbers[j,i];
            arifmetic = sum / numbers.GetLength(0);
            col ++;

    System.Console.WriteLine($"Среднее арифметическое колонки {col}: {arifmetic}");
    sum = 0;
    }
}

Console.Clear();
System.Console.WriteLine("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int colomn = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int [row, colomn];
FillArrayNumbers(numbers);
PrintArrayNumbers(numbers);
SumColomn(numbers);