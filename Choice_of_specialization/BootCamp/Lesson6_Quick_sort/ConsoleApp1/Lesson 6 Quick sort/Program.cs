/*
1. {1, 0, -6, 2, 5, 3, 2}
2. array[6] - pivot (Опорный элемент)


*/

using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

Random rnd = new Random();

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + String.Join(", ", array) + "]");
} 

void QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return;
}

int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    return pivotIndex;
}

void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}

int[] array = new int[10];

array = FillArray(array);

PrintArray(array);

QuickSort(array, 0, array.Length-1);

PrintArray(array);






