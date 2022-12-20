Console.WriteLine("Введите первое число");
int Number1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число");
int Number2 = int.Parse(Console.ReadLine() ?? "");
if (Number1 > Number2)
{
    Console.WriteLine($"{Number1}>{Number2}");
    Console.WriteLine($"Max={Number1}");
}
else
{
    Console.WriteLine($"{Number1}<{Number2}");
    Console.WriteLine($"Max={Number2}");
};