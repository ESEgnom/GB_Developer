int [] arr = {15, 21, 39, 12, 23, 33, 13, 23, 33};

int n = arr.Length;
int find = 23;
int index = 0;

while (index < n)
{
    if (arr[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
