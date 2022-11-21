// имеется массив array и n элементов, требуется найти элемент массива равный find

int[] array = {50, 1, 8, 47, 33, 7, 23, 9};
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
Console.WriteLine("end");