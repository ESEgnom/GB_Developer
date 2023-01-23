int[] CreateArray(int length, int range) 
// метод создает массив целочисленных значений.
// аргумент length задает размер массива
// аргумент range задает предел заполняемых чисел
{
    int [] array = new int [length];
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(1, range);
        index ++;
    }
    return array;
}

void PrintArray(int[] collection)
// печатает в консоль принимаемый в качестве аргумента массив
{
    int index = 0;
    while(index < collection.Length)
    {
        Console.Write($"{collection[index]} ");
        index ++;
    }
    Console.WriteLine();
}

int IndexOf(int[] collection, int find)
// находит значение find в принимаемом массиве
 {
    int count = collection.Length;
    int index = 0;
    int pos = -1;
    while(index < count)
    {
        if (collection[index] == find)
        {
           pos = index;
           break;
        }
        index ++;
    }
    return pos;
 }

int[] array = CreateArray(10, 25);

PrintArray(array);

Console.WriteLine(IndexOf(array, 15));