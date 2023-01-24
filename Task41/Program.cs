// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 (В описании задачи ошибка: "-> 4", а не "-> 3")

int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
        result[i] = int.Parse(numS[i]);
    return result;
}

int GetCountPositiveElements(int[] array)
{
    int count = 0;
    foreach (int item in array)
        if (item > 0)
            count++;
    return count;
}

Console.Write("Введите числа через пробел: ");
int[] numbers = GetArrayFromString(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0 -> {GetCountPositiveElements(numbers)}");
Console.WriteLine();

