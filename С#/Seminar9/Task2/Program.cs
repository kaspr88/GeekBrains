// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
int M = 0;
int N = 0;
inputMN(ref M, ref N);

Console.WriteLine($"Сумма элементов от {M} до {N} = {Namber(M, N)}");

void inputMN(ref int a, ref int b)
{
    try
    {
        Console.Write("Введите значение M : ");
        a = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите значение N: ");
        b = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.Write("Не верный формат", ex);
    }
}

int Namber(int m, int n)
{
    if (m == n)
        return n;
    return n + Namber(m, n - 1);
}
