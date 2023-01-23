// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты первой точки");
Console.Write("x: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Второй точки");
Console.Write("x: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int bZ = Convert.ToInt32(Console.ReadLine());

double FindLengthAB(int coordAX, int coordAY, int coordAZ, int coordBX, int coordBY, int coordBZ)
{
    int x = coordBX - coordAX;
    int y = coordBY - coordAY;
    int z = coordBZ - coordAZ;
    return Math.Sqrt(x * x + y * y + z * z);
}
double lengthAB = FindLengthAB(aX, aY, aZ, bX, bY, bZ);
lengthAB = Math.Round(lengthAB, 2, MidpointRounding.ToZero);
Console.WriteLine($"A({aX}, {aY}, {aZ}), B({bX}, {bY}, {bZ}) -> {lengthAB}");
