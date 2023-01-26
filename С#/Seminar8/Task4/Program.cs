// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int columns = 0;
int rows = 0;
inputSizeArray(ref rows, ref columns);
int[,] array0 = randomFillArray(columns, rows, 0, 10);
int[,] array1 = replacementRows(array0);
printArray(array0);
printReplayArray(array1);
/////////////////Ввод размерности массива///////////////////////////
void inputSizeArray(ref int a, ref int b)
{
    try
    {
        Console.Write("Введите колличество столбцов: ");
        a = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите колличество строк: ");
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
int[,] replacementRows(int[,] arr)
{
    int[,] array = new int[arr.GetLength(1), arr.GetLength(0)];
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                array[i, j] = arr[i, j];
            }
        }

    }
    return array;
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
///////////////////////////////
void printReplayArray(int[,] arr)
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