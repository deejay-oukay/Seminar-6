// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 (В описании задачи ошибка: "-> 4", а не "-> 3")

//число M заранее не определено
int m = new Random().Next(5,10);
int[] array = new int[m];

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray()
{
    for (int i = 0; i < m; i++)
        array[i] = InputInt($"Введите {(i+1)} число из {m}: ");
}

int OnlyPositive()
{
    int count = 0;
    foreach (int item in array)
        if (item > 0)
            count++;
    return count;
}

FillArray();

Console.WriteLine("Положительных чисел: "+OnlyPositive());

