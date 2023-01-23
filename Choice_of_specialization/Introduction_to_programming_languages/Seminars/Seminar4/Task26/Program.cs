// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите чило");
int number = Convert.ToInt32(Console.ReadLine());

int FindCount(int num)
{
    if(num < 0) num = -num;
    int count;
    for (count = 0; num > 0; count++)
    {
        num /= 10;
    }
    return count;
}

int result = FindCount(number);
System.Console.WriteLine($"{number} => {result}");