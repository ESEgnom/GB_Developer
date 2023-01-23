// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите натуральное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите натуральное значение степени: ");
int userDegree = Convert.ToInt32(Console.ReadLine());

int FindDegree(int num, int degree)
{
    int res = num;
    if(degree <= 0) System.Console.WriteLine("Введено не корректное значение степени");
    for (int i = 1; i < degree; i++)
    {
        res *= num;
    }
    return res;
}
int result = FindDegree(userNumber, userDegree);
System.Console.WriteLine($"{userNumber}, {userDegree} => {result}"); 