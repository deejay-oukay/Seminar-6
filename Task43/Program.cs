// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputDouble(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

string LineCrossing()
{
    double b1 = InputDouble("Введите значение b1: ");
    double k1 = InputDouble("Введите значение k1: ");
    double b2 = InputDouble("Введите значение b2: ");
    double k2 = InputDouble("Введите значение k2: ");

    if ((k1 == k2) && (b1 == b2))
        return "Прямые - одинаковы";
    else if (k1 == k2)
        return "Прямые - параллельны";
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        return "Прямые пересекаются в точке с координатами: X = " + x + ", Y = " + y;
    }
}

Console.WriteLine(LineCrossing());