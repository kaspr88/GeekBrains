Console.Clear();
int A = 2;
int B = 4;
inputNumbers(ref A, ref B);
int result = degreeOfNumber(A, B);
Console.WriteLine($"{A}, {B} -> {result}");
static void inputNumbers(ref int A, ref int B)
{
    try
    {
        Console.Write("Введите число A: ");
        A = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите число B: ");
        B = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Не верный формат {ex}");
    }
}
int degreeOfNumber(int A, int B)
{
    int res = 1;
    for (int i = 1; i <= B; i++)
    {
        res *= A;
    }
    return res;
}