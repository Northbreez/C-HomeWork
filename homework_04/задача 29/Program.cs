// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



void PrintArray()
{
    int[] numbers = new int[8];
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("Введите любое число для включения в массив:");
        numbers[i] = int.Parse(Console.ReadLine());
    }
    foreach (int item in numbers)
    {
        System.Console.Write(item + ", ");
    }

}
PrintArray();
