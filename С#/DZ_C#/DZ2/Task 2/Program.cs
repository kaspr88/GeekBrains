/*Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.*/
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "");
int count = 0;
int result = number;
if (result > 100)
{
    while (result > 1000)
    {
        result = result / 10;
        count++;
    }
    result = result % 10;
    Console.WriteLine($"{number} -> {result}");
}
else
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}


