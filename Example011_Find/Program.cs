Console.Clear();

// int[] array = {1,23,12,15,354,34,2354,12,5785,12};
// int n = array.Length;
// int find = 12;

// int index = 0;

// while(index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine($"finding index is {index}");
//         break;
//     }
//     index++;
// }
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 3);
Console.WriteLine($"index what are you looking for is {pos}.");