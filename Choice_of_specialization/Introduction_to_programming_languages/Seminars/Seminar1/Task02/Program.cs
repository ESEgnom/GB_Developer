// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите целое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно целое число");
int secondNum = Convert.ToInt32(Console.ReadLine());
if(firstNum > secondNum)
{
    Console.WriteLine($"{firstNum} больше чем {secondNum}");
}
else
{
    Console.WriteLine($"{firstNum} меньше чем {secondNum}");
}