// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int row, int colomn)
{
    int[,] matrix = new int[row, colomn];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 2} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


int[,] Multiplying(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplying = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < multiplying.GetLength(0); i++)
        {
            for (int j = 0; j < multiplying.GetLength(1); j++)
            {
                multiplying[i, j] = 0;
                for (int n = 0; n < multiplying.GetLength(1); n++)

                    multiplying[i, j] += matrix1[i, n] * matrix2[n, j]; 
            }
        }
    return multiplying;
}


Console.Clear();
System.Console.WriteLine("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int colomn = Convert.ToInt32(Console.ReadLine());
int[,]matrix1 = FillArray(row, colomn);
int[,]matrix2 = FillArray(row, colomn);
int[,]multiplying;
PrintArray(matrix1);
PrintArray(matrix2);
PrintArray(Multiplying(matrix1, matrix2));