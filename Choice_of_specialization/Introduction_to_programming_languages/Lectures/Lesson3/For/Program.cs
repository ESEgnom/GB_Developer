string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method4(10, "z");
// Console.WriteLine(res);

//for (int i = 2; i <= 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+"вы бы взяли приступом согласие прусского короля."
+"Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";     
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
string secondText = Replace(newText, 'к', 'К');
Console.WriteLine(secondText);
string thidText = Replace(secondText, 'C', 'c');
Console.WriteLine(thidText);