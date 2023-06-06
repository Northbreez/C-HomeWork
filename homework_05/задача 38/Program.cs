// Задача 38: Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10,99);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void DifferenceNum(int[] array)
{
    int maxValue = array.Max<int>();
    int mixValue = array.Min<int>();
    
    System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxValue - mixValue}");
}

Console.Clear();
System.Console.WriteLine("Введите размерность массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
DifferenceNum(array);