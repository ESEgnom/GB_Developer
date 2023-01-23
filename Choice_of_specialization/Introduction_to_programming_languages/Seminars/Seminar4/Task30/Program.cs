// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

System.Console.WriteLine("Введите значение размера массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите начальное значение диапазона заполнения массива");
int minRangeArray = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите конечное значение диапазона заполнения массива");
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

int[] array = FillArray(8, 0, 2);
PrintArray(array);
