int i = 0;
int[] arr = new int[7];
int sum = 0;

while(i < 7)
{
    Console.WriteLine("Введите число");
    
    arr[i] = Convert.ToInt32(Console.ReadLine());

    sum += arr[i];

    i ++;
}
int avg = sum / arr.Length;
Console.WriteLine(avg);
