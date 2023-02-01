// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Hello, World!");
int m = 0;
int n = 0;
inputNumber(ref m, ref n);
int a = recursion(m, n);
Console.Write($"A = {a};");
void inputNumber(ref int a, ref int b)
{

    try
    {
        Console.Write("Введите число M: ");
        a = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите число N: ");
        b = int.Parse(Console.ReadLine() ?? "");

    }
    catch (Exception ex)
    {
        Console.Write("Не верный формат", ex);
    }
}

int recursion(int m, int n)
{
    if (m == 0)
    {
        return 0;
    }
    int A = 0;
    if (m == 0) A = n + 1;
    if (n == 0) A = recursion(m - 1, 1);
    if (n > 0 && m > 0) A = recursion(m - 1, recursion(m, n - 1));
    return A;
}