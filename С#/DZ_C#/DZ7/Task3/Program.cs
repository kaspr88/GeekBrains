//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int columns = 0;
int rows = 0;
inputSizeArray(ref rows, ref columns);
int[,] array0 = randomFillArray(columns, rows, 0, 10);
printArray(array0);
arithmeticMean(array0);
//Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", array1)}");
////////////////////////////////////////////
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
///////////////////////////////////////////
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
////////////////////////////////////////////
void arithmeticMean(int[,] arr)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double a = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            a = Math.Round((Convert.ToDouble(a) + Convert.ToDouble(arr[j, i])));
        }
        a = Math.Round((Convert.ToDouble(a)) / arr.GetLength(0), 1);
        Console.Write($" {a} ");
    }

}
///////////////////////////////////////////
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

}