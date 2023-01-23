// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void ConvertToBin(int num)
{
    if (num > 1)
    {
        ConvertToBin(num / 2);    
    }
    System.Console.Write(num % 2);
}


while(true)
{
    Console.Write("Введите целое положительное число: ");
    string valueStr = Console.ReadLine();
    if (valueStr == "end") break;
    else
    {
        int value = Convert.ToInt32(valueStr);
        ConvertToBin(value);
        System.Console.WriteLine();
    }
}
