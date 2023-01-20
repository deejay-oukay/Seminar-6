// Принять на вход три числа и проверить может ли существовать треугольник с сторонмами такой длины
// Теорема о неравенстве треугольника: Каждая сторона треугольника меньше суммы двух других сторон

int[] array = new int[3];

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
        array[i] = InputInt($"Введите длину {i+1}-й стороны треугольника: ");
}

string Check()
{
    for (int j = 0; j < array.Length; j++)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
            if (i != j)
                sum += array[i];
        if (array[j] >= sum)
            return "Такой треугольник НЕ может существовать";
    }
    return "Такой треугольник может существовать";
}

FillArray();
Console.WriteLine(Check());