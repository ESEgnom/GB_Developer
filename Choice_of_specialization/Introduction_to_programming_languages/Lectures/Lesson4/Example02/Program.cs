void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int [,] matrix = new int[3, 3];
/*                       ^  ^
                 СТРОКА__|  |__ СТОЛБИК

    Структура двумерного массива matrix[3, 3]
    matrix[0, 0] matrix[0, 1] matrix[0, 2] 
    matrix[1, 0] matrix[1, 1] matrix[1, 2]  
    matrix[2, 0] matrix[2, 1] matrix[2, 2] 
*/

void FillArray(int[,] matr)
{
    int count = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (count <= 12)
            {
                matr[i, j] = count;
                count++;
            }
        }
        // System.Console.WriteLine();
    }
}

PrintMatrix(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);


