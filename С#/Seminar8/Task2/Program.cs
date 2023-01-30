// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int columns = 0;
int rows = 0;
inputSizeArray(ref rows, ref columns);
int[,] array0 = randomFillArray(columns, rows, 0, 10);
int[,] array1 = replacementRowsToColoms(array0);
replacementRowsToColoms(array0);
printArray(array0);
printReplacementArray(array1);
/////////////////Ввод размерности массива///////////////////////////
void inputSizeArray(ref int a, ref int b)
{
    try
    {
        Console.Write("Введите колличество строк: ");
        a = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите колличество столбцов: ");
        b = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.Write("Не верный формат", ex);
    }
}
//////////Заполнение массива рандомными числами/////////////////////
int[,] randomFillArray(int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}
/////////////////Поиск среднего арифметического////////////////////
int[,] replacementRowsToColoms(int[,] arr)
{
    int[,] res = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res[j, i] = arr[i, j];
        }
    }
    return res;
}
//////////////////////////Вывод массива///////////////////////////
void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}
//////////////////////////////////////////////////////////////////
void printReplacementArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine("");
    }
}