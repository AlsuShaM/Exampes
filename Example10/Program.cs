// имеется массив array и n элементов, требуется найти элемент массива равный find

int[] array = {5, 1, 8, 2, 33, 7, 2, 9};
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
    index++;
}
