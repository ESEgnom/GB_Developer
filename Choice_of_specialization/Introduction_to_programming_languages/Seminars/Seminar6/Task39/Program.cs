// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// System.Console.Write("Введите значение размера массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите начальное значение диапазона заполнения массива: ");
// int minRangeArray = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите конечное значение диапазона заполнения массива: ");
// int maxRangeArray = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите искомое число: ");

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
    System.Console.WriteLine();
}

void ReversArray(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;

        index1++;
        index2--;
    }
}

void ReversArray2(int[] array)
{
    int size = array.Length;
    
    for (int i = 0; i < size / 2; i++)
    {
        int obj = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = obj;
    }
}



int[] userArray = FillArray(7, 1, 10);

PrintArray(userArray);

ReversArray(userArray);

PrintArray(userArray);

Array.Reverse(userArray);

PrintArray(userArray);

ReversArray2(userArray);

PrintArray(userArray);



