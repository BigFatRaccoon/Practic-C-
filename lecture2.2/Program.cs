int[] array = { 1, 42, 63, 45, 25, 36, 17, 84 };

int n = array.Length;
int find = 84;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    // index = index +1;
    index++;

}