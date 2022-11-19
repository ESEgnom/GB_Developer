// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите желаемое количество чисел: ");
int countNum  = Convert.ToInt32(Console.ReadLine());

int result = FindPositiveNum(countNum);
System.Console.WriteLine($"Вы  ввели {result} положительных числа");

int FindPositiveNum(int num)
{
    int count = default;
    for (int i = 1; i <= num; i++)
    {
        Console.Clear();
        Console.Write($"Введите желаемое число {i}: ");
        int userNum = Convert.ToInt32(Console.ReadLine());
        if (userNum > 0) count++;
    }
    return count;
}