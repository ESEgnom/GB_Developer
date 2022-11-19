// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.Write("Введите значение размера массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите начальное значение диапазона заполнения массива: ");
int minRangeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конечное значение диапазона заполнения массива: ");
int maxRangeArray = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int size, int minRange, int maxRange)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minRange, maxRange);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if(i == array.Length-1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]},");
    }
    System.Console.WriteLine("]");
}

int[] array = FillArray(sizeArray, minRangeArray, maxRangeArray);
PrintArray(array);