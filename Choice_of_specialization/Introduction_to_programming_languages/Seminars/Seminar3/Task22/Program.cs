// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

void FindSqr(int n)
{
   int count = 1;
   if (n > 0)
   {
        while (count <= n)
        {
            Console.WriteLine($"{count, 3} => {Math.Pow((count), 2)}");
            count ++;
        }
   }
   else
   {
    Console.WriteLine("Введено отрицательное значение");
   }
}

FindSqr(num);