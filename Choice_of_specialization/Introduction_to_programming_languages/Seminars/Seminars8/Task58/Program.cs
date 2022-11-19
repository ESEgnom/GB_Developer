/**
Задача 58: 
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
    System.Console.WriteLine();
}

int[,] matrix1 = CreateMatrixRndInt(2, 3, 1, 21);

int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 21);

PrintMatrix(matrix1);

PrintMatrix(matrix2);

System.Console.WriteLine("Результат произведения двух матриц");
int[,] resultMatrix = FindProductMatrices(matrix1, matrix2);

PrintMatrix(resultMatrix);

int[,] FindProductMatrices(int[,] array, int[,] array2)
{   
    int[,] productMatrix = new int[array.GetLength(0), array2.GetLength(1)];
    if(array.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(1); k++)
                {
                    productMatrix[i, j] += array[i, k] * array2[k, j];
                }
            }
        }
        return productMatrix;
    }
    System.Console.WriteLine("Матрици нельзя перемножить.");
    return productMatrix;
}