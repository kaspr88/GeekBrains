// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
int N = inputN();
int M = 1;
Console.WriteLine(Number(N, M));


int inputN()
{
    int a = 0;
    try
    {
        Console.Write("Введите N: ");
        a = int.Parse(Console.ReadLine() ?? "");

    }
    catch (Exception ex)
    {
        Console.Write("Не верный формат", ex);
    }
    return a;
}

int Number(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{Number(m, n + 1)}, ");
    return m;
}

