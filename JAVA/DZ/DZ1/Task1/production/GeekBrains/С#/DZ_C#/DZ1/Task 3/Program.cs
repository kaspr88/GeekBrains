Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "");
if (number % 2 == 0) Console.WriteLine($"Вы ввели число {number}, оно четное");
else Console.WriteLine($"Вы ввели число {number}, оно нечетное");