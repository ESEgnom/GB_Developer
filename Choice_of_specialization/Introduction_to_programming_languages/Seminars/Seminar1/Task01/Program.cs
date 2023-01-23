// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите целое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно целое число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
if(firstNum == secondNum * secondNum)
{
    Console.WriteLine($"{firstNum}, является квадратом числа {secondNum} ");
}
else
{
    Console.WriteLine($"{firstNum}, не является квадратом числа {secondNum} ");
}