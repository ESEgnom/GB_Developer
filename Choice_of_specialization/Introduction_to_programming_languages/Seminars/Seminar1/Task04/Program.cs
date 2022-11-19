// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
Console.WriteLine($"Из ряда введенных чисел {max} максимальное по значению");