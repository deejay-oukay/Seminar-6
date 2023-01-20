// Перевернуть массив (последний элемент будет на первом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void InvertArray(int[] array)
{
    PrintArray(array,"До: ");
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[^(i+1)];
        array[^(i+1)] = temp;
    }
    PrintArray(array,"После: ");
}

void PrintArray(int[] array,string message)
{
    Console.WriteLine($"{message}[{String.Join(" ",array)}]");
}

int[] array1 = {1,2,3,4,5};
int[] array2 = {6,7,3,6};
InvertArray(array1);
InvertArray(array2);