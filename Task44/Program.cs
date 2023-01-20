// Не использую я рекурсию, вывести первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonacci(int n)
{
    int[] array = new int[n];
    int i = 0;
    while(i < n)
    {
        if (i < 2)
            array[i] = i;
        else
            array[i] = array[i-1] + array[i-2];
        i++;
    }
    Console.WriteLine($"Если N = {n} -> {String.Join(" ", array)}");
}

Fibonacci(5);
Fibonacci(3);
Fibonacci(7);