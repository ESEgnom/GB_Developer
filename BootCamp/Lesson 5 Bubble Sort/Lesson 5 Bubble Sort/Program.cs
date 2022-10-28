Console.Write("Введите значение длинны массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int[n];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 100);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

for (int i = 0; i < array.Length; i++)
{
    for (int j = 1; j < array.Length; j++)
    {
        if (array[j] < array[j - 1])
        {
            (array[j - 1], array[j]) = (array[j], array[j - 1]);
        }
    }
    Console.WriteLine(i + "[" + String.Join(", ", array) + "]");
}
Console.WriteLine();
Console.WriteLine("[" + String.Join(", ", array) + "]");