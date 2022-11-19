// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

System.Console.Write("Введите длинну первой стороны: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите длинну второй стороны: ");
int numB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите длинну третьей стороны: ");
int numC = Convert.ToInt32(Console.ReadLine());

bool IsTriangleReal(int a, int b, int c)
{
    bool res = false;
    if(a + b > c || b + c > a || c + a > b) res = true;
    return res;
}

string result = IsTriangleReal(numA, numB, numC) ? "ДА" : "НЕТ";
System.Console.WriteLine(result);