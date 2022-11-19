/**
Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
*/

System.Console.Write("Введите первую координату искомого элемента: ");
int userIndexI = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите вторую координату искомого элемента: ");
int userIndexJ = Convert.ToInt32(Console.ReadLine());

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

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);

int PrintElement(int[,] array, int indexI, int indexJ)
{
    return indexI <= array.GetLength(0) && indexJ <= array.GetLength(1)? array[indexI, indexJ] : -1;
}

PrintMatrix(array2d);

int result = PrintElement(array2d, userIndexI, userIndexJ);
string answer = result == -1 ? $"({userIndexI}, {userIndexJ}) => Такого элемента нет." : $"({userIndexI}, {userIndexJ}) => {array2d[userIndexI, userIndexJ]}";
System.Console.WriteLine(answer);
