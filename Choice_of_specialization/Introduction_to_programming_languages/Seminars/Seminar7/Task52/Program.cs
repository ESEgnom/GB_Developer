/**
Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}; ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void PrintResult(double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        if (i == matrix.Length-1)
        {
            System.Console.Write(matrix[i]);
        }
        else
        {
            System.Console.Write($"{matrix[i]}; ");
        }
        
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);

PrintMatrix(array2d);
System.Console.WriteLine();

double[] FindArithmeticMean(int[,] array)
{
    double[] arrayResult = new double[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        double result = sum / array2d.GetLength(0);
        result = Math.Round(result, 1);
        arrayResult[i] = result;     
    }
    return arrayResult;
}

double[] resultArray = FindArithmeticMean(array2d);
System.Console.Write("Среднее арифметическое каждого столбца: ");
PrintResult(resultArray);




