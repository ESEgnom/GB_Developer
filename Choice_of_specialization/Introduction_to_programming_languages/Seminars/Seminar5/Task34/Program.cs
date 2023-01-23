// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

System.Console.Write("Введите значение размера массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int minRangeArray = 100;
int maxRangeArray = 999;

int[] FillArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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
    System.Console.Write("]");
}

int[] userArray = FillArray(sizeArray, minRangeArray, maxRangeArray);
PrintArray(userArray);

int FindCountEvenNumbers(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)
       {
            count++;
       } 
    }
    return count;
}

int countEvenNumbers = FindCountEvenNumbers(userArray);

System.Console.WriteLine($" => {countEvenNumbers}");