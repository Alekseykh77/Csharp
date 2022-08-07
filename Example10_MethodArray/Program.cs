int[] array = {1,12,31,4,4,61,71,81};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; // index = index + 1;
}
