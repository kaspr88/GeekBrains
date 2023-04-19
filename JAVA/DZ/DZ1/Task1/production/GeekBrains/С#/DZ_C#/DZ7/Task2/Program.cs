// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int m = 0;
int n = 0;
inputSizeArray("Введите размер массива: ", "Ошибка ввода", ref m, ref n);
int[,] arr = randomFillArray(m, n, 0, 11);
Console.Write($"Введите искомое значение: ");
int num = inputInNum();
printArray(arr);
bool result = checingNumber(arr, num);
if (result) Console.WriteLine($"Значение {num} существует");
else Console.WriteLine($"Значение {num} не существует");
//////////Заполнение массива рандомными числами////////////////////
int[,] randomFillArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return array;
}
/////////////////////Ввод и проверка искомого значения/////////////
int inputInNum()
{
    int num = 0;
    try
    {
        num = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Введены не верные данные", ex);
    }
    return num;
}
//////////////////////////Вывод массива///////////////////////////
void printArray(int[,] array)
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
/////////////////////Поиск введенного числа в массиве/////////////
bool checingNumber(int[,] array, int num)
{
    bool n = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((array[i, j]) == num) n = true;
        }
    }
    return n;
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
