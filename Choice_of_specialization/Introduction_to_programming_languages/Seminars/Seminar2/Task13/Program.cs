int digit = 645;
int digit2 = 78;
int digit3 = 32679;

void FindThirdDigit(int num)
{
        if(num >= 1000)
    {
        while(num > 1000)
        {
            num  /= 10;
        }
        int result = num % 10;
        Console.WriteLine($" -> {result}");
    }
    else if(num >= 100)
    {
        int result = num % 10;
        Console.Write($" -> {result}");
    }
    else
    {
        Console.Write($" -> Третьей цифры нет");
    }
}

Console.Write(digit);
FindThirdDigit(digit);
Console.WriteLine();

Console.Write(digit2);
FindThirdDigit(digit2);
Console.WriteLine();

Console.Write(digit3);
FindThirdDigit(digit3);