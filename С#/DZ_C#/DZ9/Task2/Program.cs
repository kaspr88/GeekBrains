// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int M = 0;
int N = 0;
inputNumber(ref M, ref N);
int sum = recursion(M, N);
Console.Write($"M = {M}; N = {N} --> {sum} ");
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
int recursion(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    M = M + recursion(M + 1, N);
    return M;
}
