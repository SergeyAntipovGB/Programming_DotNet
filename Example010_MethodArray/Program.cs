int[] array = { 1, 17, 31, 4, 15, 16, 17, 18 };

int n = array.Length;
int find = 17;

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