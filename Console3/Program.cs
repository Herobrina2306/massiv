int[] array = {31, 26, 23, 93, 64, 53, 65, 27, 81, 93};

int n = array.Length;
int find = 93;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}