// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int FindNewDigit(int num)
{
    if(num > 100 && num < 1000)
    {
        int result = num % 100 / 10;
        return result;
    }
    else
    {
        Console.WriteLine("Введено некорректное Значение");
        return -1;
    }
}
int res = FindNewDigit(number);
Console.WriteLine(res);
