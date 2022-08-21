int[] array = {1, 63, 33, 14, 51, 63, 7, 8};

int n = array.Length;

int find = 63;
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
