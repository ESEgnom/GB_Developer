/**
Задача 56: 
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка
*/

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

void PrintArray(int[] array)
{
    Console.Write("|");
    for (int j = 0; j < array.Length; j++)
    {
        if (j < array.Length - 1) Console.Write($"{array[j], 4} | ");
        else Console.Write($"{array[j], 4} ");
    }
        Console.WriteLine("|");
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 11);

PrintMatrix(matrix);

int FindMinSumElem(int [,] array)
{
    int[] sum = new int[array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    
    System.Console.WriteLine();
    PrintArray(sum);
    
    int minSum = sum[0];
    int minIndex = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if(sum[i] < minSum)
        {
            minSum = sum[i];
            minIndex = i;
        }
    }
    System.Console.WriteLine($"Минимальная сумма елементов => {minSum}");
    return minIndex;
}

int indexOfMinElem = FindMinSumElem(matrix);
System.Console.WriteLine($"Индекс строки сумма элементов которой минимальна => {indexOfMinElem}");