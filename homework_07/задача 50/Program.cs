// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//  и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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


void SearchNumbers(int[,] numbers)
{
System.Console.WriteLine("Введите искомое число:");
int search = Convert.ToInt32(Console.ReadLine());


 int str = -1;
 int col = -1;
 bool f = false;
for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (search == numbers[i, j]) {str = i; col = j; f = true; };
            // Console.Write("{0}\t", numbers[i, j]);
        }
    }  
System.Console.WriteLine();

if (f)
    System.Console.WriteLine($"Искомое число {search} на строке {str+1}, столбце {col+1}");
else 
    System.Console.WriteLine("Такого числа в массиве нет");
}

Console.Clear();
System.Console.WriteLine("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int colomn = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int [row, colomn];

FillArrayNumbers(numbers);
PrintArrayNumbers(numbers);
SearchNumbers(numbers);