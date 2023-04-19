/*Напишите программу, которая принимает на вход трёхзначное
 число и на выходе показывает вторую цифру этого числа.*/
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine() ?? "");
int a = number % 100;
int b = a / 10;
Console.WriteLine($"{number}->{b}");
