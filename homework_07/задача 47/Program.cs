// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArrayNumbers(double[,] numbers)
{
    Random num = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
        for (int j = 0; j < numbers.GetLength(1); j++)
        numbers[i, j] = new Random().NextDouble()* 100;
}

void PrintArrayNumbers(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]}        ");
            
        }
    System.Console.WriteLine();
    }
}

Console.Clear();
System.Console.WriteLine("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int colomn = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double [row, colomn];
FillArrayNumbers(numbers);
PrintArrayNumbers(numbers);