﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
} 
else
if (n < 0)
{
    for (int i = 1; i >= n; i--)
    {
        if (i % 2 == 0 && i != 0)
        {
            Console.WriteLine(i);
        }
    }
}
