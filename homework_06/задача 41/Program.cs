// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Введите любое число для включения в массив:");
    numbers[i] = int.Parse(Console.ReadLine());
}
foreach (int item in numbers)
{
    System.Console.Write(item + ", ");
}

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        count += 1;
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество чисел в массиве, которые больше 0 = {count}");
