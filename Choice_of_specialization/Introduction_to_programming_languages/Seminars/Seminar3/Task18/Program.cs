// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
string quarterNum = Console.ReadLine();

string FindRange(string num)
{
    string phrase = "Диапазон координат находится в пределах";
    
    if(num == "1") return $"{phrase} X > 0 и Y > 0";
    if(num == "2") return $"{phrase} X < 0 и Y > 0";
    if(num == "3") return $"{phrase} X < 0 и Y < 0";
    if(num == "4") return $"{phrase} X > 0 и Y < 0";
    return "Введены неверные данные";
}

string range = FindRange(quarterNum);
Console.WriteLine(range);