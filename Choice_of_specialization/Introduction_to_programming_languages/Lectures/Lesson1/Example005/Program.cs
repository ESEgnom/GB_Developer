int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int c = new Random().Next(1, 10);
int d = new Random().Next(1, 10);
int e = new Random().Next(1, 10);
int f = new Random().Next(1, 10);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
if (f > max) max = f;

Console.WriteLine(max);