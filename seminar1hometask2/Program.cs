﻿// Напишите программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b>max)
{
    max = b;
    if (c>max)
    {
        max = c;
    }
}

Console.Write($"max = {max}");