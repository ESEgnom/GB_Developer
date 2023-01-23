int[] FillArray(int range)
{
    int[] array = new int[range];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] array = FillArray(10);
PrintArray(array);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }    

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
SelectionSort(array);
PrintArray(array);
