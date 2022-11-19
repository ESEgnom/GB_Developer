// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());

int MakeFactorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}
int result = MakeFactorial(number);
System.Console.WriteLine($"{number} => {result}");
