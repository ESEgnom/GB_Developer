/**
Задача 60. 
...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int range)
{
    int[,,] matrix = new int[rows, columns, depth];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = range;
                range += 1;
            }
            
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (k < array.GetLength(1) - 1) Console.Write($"{array[i, j, k], 4}({i},{j},{k})");
                else Console.Write($"{array[i, j, k], 4}({i},{j},{k})");
            }
        }
        System.Console.WriteLine();
    }
}

int[,,] matrix = CreateMatrixRndInt(2, 2, 2, 10);

PrintMatrix(matrix);