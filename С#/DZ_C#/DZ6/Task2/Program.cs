// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double b1 = 0;
double k1 = 0;
double b2 = 0;
double k2 = 0;
inputNumbers(ref b1, ref k1, ref b2, ref k2);
dotSeach(b1, k1, b2, k2);

void inputNumbers(ref double b1, ref double k1, ref double b2, ref double k2)
{
    try
    {
        Console.Write($"Введите значение b1:");
        b1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите значение k1: ");
        k1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите значение b2: ");
        b2 = double.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите значение k2:");
        k2 = double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка ввода!", ex);
    }
}

static void dotSeach(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * (b2 - b1) / (k1 - k2) + b1;
        Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} --> ({x};{y})");
    }
    else
    {
        Console.WriteLine($"Прямые не пересекаются!");
    }

}
