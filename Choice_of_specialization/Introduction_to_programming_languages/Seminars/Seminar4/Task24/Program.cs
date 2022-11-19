// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

System.Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());

int MakeSum(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
int result = MakeSum(number);
System.Console.WriteLine($"{number} => {result}");