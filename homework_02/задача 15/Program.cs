﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// // 1 -> нет

Console.WriteLine("Введите любое число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7)
    Console.WriteLine("Не верно введено число");
else if (num >=6)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет"); 