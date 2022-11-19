// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

while (true) //до тех пор пока в консоли не будет введено слово "end" программа будет запрашивать новое число
             //и выводить результат в консоль
{
    System.Console.Write("Введите натуральное число: ");
    string userValue = Console.ReadLine();

    if(userValue == "end") break; 
    else 
    {
        int userNumber = Convert.ToInt32(userValue);
        int result = FindSumDigit(userNumber);
        System.Console.WriteLine($"{userNumber} => {result}");
    }
}

int FindSumDigit(int num)
    {
        int sum = 0;
        for (int i = 0; num > 0; i++)
        {
            int temp = num % 10;
            num /= 10;
            sum += temp;
        }
        return sum;
    }
