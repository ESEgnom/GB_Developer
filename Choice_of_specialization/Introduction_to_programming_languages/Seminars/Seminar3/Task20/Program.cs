// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double num = 3.09987565; // 3.09
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(numRound);

Console.WriteLine("Введите координаты первой точки");
Console.Write("x: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Второй точки");
Console.Write("x: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int bY = Convert.ToInt32(Console.ReadLine());

double FindLengthAB(int coordAX, int coordAY, int coordBX, int coordBY)
{
    int x = coordBX - coordAX;
    int y = coordBY - coordAY;
    return Math.Sqrt(x * x + y * y);
}
double lengthAB = FindLengthAB(aX, aY, bX, bY);
lengthAB = Math.Round(lengthAB, 2, MidpointRounding.ToZero);
Console.WriteLine($"A({aX},{aY}), B({bX},{bY}) -> {lengthAB}");
