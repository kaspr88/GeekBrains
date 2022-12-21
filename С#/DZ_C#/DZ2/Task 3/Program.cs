/*Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.*/
Console.Write("Введите число от 1 до 7:");
int number = int.Parse(Console.ReadLine() ?? "");
if (number < 7) Console.WriteLine($"{number} -> да");
else Console.WriteLine($"{number} -> нет");