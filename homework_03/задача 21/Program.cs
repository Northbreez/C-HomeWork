// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
 double distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + (Math.Pow(z2 - z1,2)));
 return distance;
}

Console.Clear();
System.Console.WriteLine("Введите координаты точки 'A' x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки 'A' y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки 'A' z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки 'B' x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки 'B' y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки 'B' z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Расстояние между точками - {distance(x1, y1, z1, x2, y2, z2)}");