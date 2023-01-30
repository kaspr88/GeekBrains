// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int columns = 0;
int rows = 0;
int minValue = 0;
int maxValue = 10;
inputSizeArray(ref rows, ref columns);
int[,] array0 = randomFillArray(columns, rows, minValue, maxValue);
int[,] array1 = randomFillArray(columns, rows, minValue, maxValue);
int[,] array2 = multiplyingArrays(array0, array1);
printArray(array0);
printArray(array1);
printArray(array2);


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

int[,] multiplyingArrays(int[,] arr1, int[,] arr2)
{
    int[,] array = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
    return array;
}