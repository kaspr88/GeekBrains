// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int N = inputNumber();
//Console.Write($"N = {N} --> \"");
//Console.Write($"{recursion(N)}\"");

int inputNumber()
{
    int a = 0;
    try
    {
        Console.Write("Введите число N: ");
        a = int.Parse(Console.ReadLine() ?? "");

    }
    catch (Exception ex)
    {
        Console.Write("Не верный формат", ex);
    }
    return a;
}
int recursion(int N)
{
    if (N == 1)
    {
        return 1;
    }
    Console.Write($"{N}, ");
    N--;
    return recursion(N);



}