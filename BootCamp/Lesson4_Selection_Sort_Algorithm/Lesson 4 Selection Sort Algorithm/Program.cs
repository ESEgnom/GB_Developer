Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{ 
    array[i] = rnd.Next(1, 100);
}
Console.WriteLine();
Console.WriteLine("[" + string.Join(", ", array) + "]");
for (int i = 0; i < n-1; i++)
{
    int MinIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[j] < array[MinIndex]) MinIndex = j;
    }

    int temp = array[MinIndex];
    array[MinIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");