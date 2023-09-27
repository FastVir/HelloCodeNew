int[] array = { 1, 12, 45, 55, 66, 777, 88888, 55, 1111111, 4 };

int n = array.Length;
int find = 55;

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