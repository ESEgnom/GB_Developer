// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

System.Console.Write("Введите значение размера массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите начальное значение диапазона заполнения массива: ");
int minRangeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конечное значение диапазона заполнения массива: ");
int maxRangeArray = Convert.ToInt32(Console.ReadLine());

double[] FillArray(int size, int minRange, int maxRange)
{
    Random rnd = new Random();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        double temp = rnd.NextDouble() * (maxRange - minRange) + minRange;
        double tempRound = Math.Round(temp, 2, MidpointRounding.ToZero);
        array[i] = tempRound;
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if(i == array.Length-1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}; ");
    }
    System.Console.Write("]");
}

double[] userArray = FillArray(sizeArray, minRangeArray, maxRangeArray);
PrintArray(userArray);

double FindDiffMinMaxElements(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue) maxValue = array[i];
        if (array[i] < minValue) minValue = array[i];
    }
    
    double temp =  maxValue - minValue;
    double diff = Math.Round(temp, 2, MidpointRounding.ToZero);
    return diff;
}

double diffMinMaxElements = FindDiffMinMaxElements(userArray);

System.Console.Write($" => {diffMinMaxElements}");