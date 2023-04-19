Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "");
int count = 2;
while (count <= number)
{
    if (count % 2 == 0) Console.Write($"{count}");
    if (count == number || count == number + 1) { Console.Write("."); }
    else { Console.Write(", "); count++; }
    count++;
}