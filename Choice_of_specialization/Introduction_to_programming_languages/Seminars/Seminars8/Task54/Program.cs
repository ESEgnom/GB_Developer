﻿// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateMatrixRndInt(int rows, int columns, int minRange, int maxRange)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minRange, maxRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 4} | ");
            else Console.Write($"{array[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 11);

PrintMatrix(matrix);

int[,] SortMatrix(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int max = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, k] > array[i, max]){
                max = k;
                }
            }
            int temp = array[i, max];
            array[i, max] = array[i, j];
            array[i, j] = temp;
        }
        
    }
    return array;
}

SortMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);


