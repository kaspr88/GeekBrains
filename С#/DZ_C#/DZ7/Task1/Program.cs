// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m = 0;
int n = 0;
inputSizeArray("Введите размер массива: ", "Ошибка ввода", ref m, ref n);
double[,] arr = randomFillArray(m, n);
Console.WriteLine($" m = {m}, n = {n} ");
printArray(arr);
//////////Заполнение массива рандомными числами////////////////////
double[,] randomFillArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(Convert.ToDouble(rnd.NextDouble() * 10 - 5), 1);
        }
    }
    return array;
}
/////////////////Ввод размерности массива/////////////////////////
void inputSizeArray(string massage, string error, ref int num1, ref int num2)
{
    try
    {
        Console.Write(massage);
        num1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write(massage);
        num2 = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine(error, ex);
    }
}
//////////////////////////Вывод массива///////////////////////////
void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}