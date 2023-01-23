// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int numDay = Convert.ToInt32(Console.ReadLine());

void IsHoliday(int num)
{
    if(num == 7 || num == 6)
    {
        Console.WriteLine($"{num} Является выходным днем");
    } 
    else if(num >= 1 && num <= 5)
    {
        Console.WriteLine($"{num} не является выходным днем");
    }
    else
    {
        Console.WriteLine("Введено неверное значение");
    }
}

IsHoliday(numDay);