// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int m = 0;
int n = 0;
inputNumber(ref m, ref n);
int a = recursion(m, n);
Console.Write($"m = {m} n = {n} --> A(m,n) = {a}");
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
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return recursion(m - 1, 1);
    if (m > 0 && n > 0) return recursion(m - 1, recursion(m, n - 1));
    return recursion(m, n);
}
Console.ReadLine();