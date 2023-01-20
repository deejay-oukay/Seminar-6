// Преобразовать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// string ToBin(int num)
// {
//     return Convert.ToString(num, 2);
// }

void ToBin(int num)
{
    Console.Write(num + " -> ");
    int[] res = new int[1];
    while ((num/2) >= 1)
    {
        res[res.Length-1] = (num % 2);
        num /= 2;
        Array.Resize(ref res,res.Length+1);
    }
    res[res.Length-1] = num;
    for (int i = 0; i < res.Length; i++)
    {
        Console.Write(res[^(i+1)]);
    }
    Console.WriteLine();
}

ToBin(45);
ToBin(3);
ToBin(2);
