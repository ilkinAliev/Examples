// циклы в цикле

int [] massive = new int[15];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 1001);
        index++;
    }
}

FillArray(massive);

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

PrintArray(massive);

int result = 0;
foreach(int n in massive)
{
    if (n > 100)
    {
        result++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество чисел больше 100 в массиве = {result}");