// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки");
Console.WriteLine("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int y = Convert.ToInt32(Console.ReadLine());

int FindQuarter(int pointX, int pointY)
{
    if(pointX > 0 && pointY > 0) return 1;
    if(pointX < 0 && pointY > 0) return 2;
    if(pointX < 0 && pointY < 0) return 3;
    if(pointX > 0 && pointY < 0) return 4;
    return 0;
}
int quarter = FindQuarter(x, y);
string res = quarter > 0 ? $"Указанные координаты соответствуют четверти => {quarter.ToString()}"
                         : "Введены не корректные значения";
Console.WriteLine(res);