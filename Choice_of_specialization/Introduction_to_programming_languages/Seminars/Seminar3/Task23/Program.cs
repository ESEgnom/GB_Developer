// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

void FindCube(int n)
{
   int count = 1;
   if (n > 0)
   {
        while (count <= n)
        {
            Console.WriteLine($"{count, 3} => {Math.Pow((count), 3)}");
            count ++;
        }
   }
   else
   {
    Console.WriteLine("Введено отрицательное значение");
   }
}

FindCube(num);