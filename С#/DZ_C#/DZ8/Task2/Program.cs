//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int columns = 0;
int rows = 0;
inputSizeArray(ref rows, ref columns);
int[,] array0 = randomFillArray(columns, rows, 0, 10);
printArray(array0);
int[] array1 = sortRows(array0);
Console.WriteLine($"{String.Join(" ", array1)}");
printSortRows(array1);
//printSortRows(array1);
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
/////////////////Сортировка массива////////////////////
int[] sortRows(int[,] array)
{
    int[] a = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {

            a[j] = a[j] + array[j, i];
            if (a[j] < a[j] + 1)
            {

            }

        }
    }
    return a;
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
/////////////////////Вывод отсортированного массива////////////////////
void printSortRows(int[] arr)
{
    int a = 0;
    int b = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (b > arr[i])
        {
            a = i + 1;

        }
        b = arr[i];
    }
    Console.WriteLine(a);
}
