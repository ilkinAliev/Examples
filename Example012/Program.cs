void FillArray(int[] randomize)
{
    int count = randomize.Length;
    int index = 0;

    while (index < count)
    {
        randomize[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] printarray)
{
    int count = printarray.Length;
    int i = 0;

    while (i < count)
    {
        Console.Write(printarray[i] + " ");
        i++;
    }
}

int Search()



int[] array = new int[10];
FillArray(array);

PrintArray(array);