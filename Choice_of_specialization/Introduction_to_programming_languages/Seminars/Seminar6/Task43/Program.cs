// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

string CrossPoint(double numB1, double numK1, double numB2, double numK2)
{
double x = (numB1 - numB2)/(numK2 - numK1);
double y = (numK2 * numB1 - numK1 * numB2)/(numK2-numK1);
return (numK1 == numK2) ? "Заданные прямые не пересекаются!" : $"Точка пересечения заданных прямых: ({x}; {y})";
}

CrossPoint(b1, k1, b2, k2);

string result = CrossPoint(b1, k1, b2, k2);
System.Console.WriteLine(result);