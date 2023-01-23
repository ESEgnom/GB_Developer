int Fibonacci(int num)
{
    if (num == 1 || num == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(num -1) + Fibonacci(num-2);
    }
}

for (int i = 1; i < 10; i++)
{
    System.Console.WriteLine($"f({i}) => {Fibonacci(i)}");
}
