// Напишите программу, которая заполнит спирально массив 4 на 4

int size = inputSizeArray();
int[,] array = new int[size, size];
FillArray(array, size);
PrintArray(array);
/////////////////Ввод размерности массива///////////////////////////
int inputSizeArray()
{
    int a = 0;
    try
    {
        Console.Write("Введите размер массива: ");
        a = int.Parse(Console.ReadLine() ?? "");

    }
    catch (Exception ex)
    {
        Console.Write("Не верный формат", ex);
    }
    return a;
}
///////////////Функция заполнения массива//////////////////////
void FillArray(int[,] array, int size)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < size * size; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; }
        while (++k < size - 1);
        for (k = 0; k < size - 1; k++)
        {
            array[i++, j] = value++;
        }
        for (k = 0; k < size - 1; k++)
        {
            array[i, j--] = value++;
        }
        for (k = 0; k < size - 1; k++)
        {
            array[i--, j] = value++;
        }
        ++i; ++j;
        size = size < 2 ? 0 : size - 2;
    }
}
//////////////////  Вывод массива ////////////////
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
