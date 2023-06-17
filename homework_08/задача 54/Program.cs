// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void ArrayRowSorted(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) -1; k++)
        {
            if (numbers[i, k] < numbers[i, k + 1])
            {
                int temp = numbers[i, k + 1];
                numbers[i, k + 1] = numbers[i, k];
                numbers[i, k] = temp;
            }
                }
        }   
    }
    System.Console.WriteLine();
}

Console.Clear();
System.Console.WriteLine("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int colomn = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[row, colomn];
FillArrayNumbers(numbers);
PrintArrayNumbers(numbers);
ArrayRowSorted(numbers);
PrintArrayNumbers(numbers);