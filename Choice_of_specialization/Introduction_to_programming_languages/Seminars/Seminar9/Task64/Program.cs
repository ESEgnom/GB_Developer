﻿/*
 Задача 64: Задайте значения N. Напишите программу, которая 
 выведет все натуральные числа в промежутке от N до 1.
 N = 5. -> "5, 4, 3, 2, 1"
 N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
 */
 
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

System.Console.Write($"N = {number}. -> ");
ShowLineNumber(number, count);


void ShowLineNumber(int num, int count)
{
    if (count > num)
    {
        return;
    }
    else
    {
        ShowLineNumber(num, count + 1);
        Console.Write(count + " ");
    }
}
