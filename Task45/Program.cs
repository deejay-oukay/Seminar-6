// Создать копию заданного массива с помощью по элементного массива

int[] array = new int[10];

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(" ",array)}]");
}

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(-99,100);
    PrintArray(array);
}

void CopyArray(int[] original)
{
    int[] copy = new int[original.Length];
    for (int i = 0; i < original.Length; i++)
        copy[i] = original[i];
    PrintArray(copy);
}

FillArray();
CopyArray(array);

