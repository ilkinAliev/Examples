int[] array = { 1, 33, 45, 65, 78, 76, 344, 32, 12, 344 };

int n = array.Length;
int find = 344;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
