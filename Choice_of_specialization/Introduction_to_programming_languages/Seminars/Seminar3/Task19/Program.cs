// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());


string IsPolindrom(int n)
{
    int temp = n;
    int rev = 0;
    while (temp > 0)
    {
        int dig = temp % 10;
        rev = rev * 10 + dig;
        temp /= 10;
    }
    return rev == n ? $"{n} -> да" : $"{n} -> нет";
}
string res = IsPolindrom(number);
Console.WriteLine(res);