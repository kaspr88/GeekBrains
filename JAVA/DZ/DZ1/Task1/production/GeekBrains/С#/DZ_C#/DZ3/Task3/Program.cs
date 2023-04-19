/*Напишите программу, которая принимает на вход число 
(N) и выдаёт таблицу кубов чисел от 1 до N.*/
Console.Clear();
int N = 0;
inputN(ref N);
tableReturn(N);
static int inputN(ref int N)
{
    try
    {
        Console.Write("Введите  число N:");
        N = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.Write($"Не верный формат {ex}");
    }
    return N;
}

static double tableReturn(int N)
{
    int count = 1;
    double result = 0;
    Console.Write($"{N} -> ");
    while (count <= N)
    {
        result = Math.Pow(count, 3);
        Console.Write($"{result}");
        count++;
        if (count <= N) Console.Write($", ");
        else Console.Write($".");
    }
    return result;
}
