// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = inputArr("Введите элемент");
outputArr(array);

int[] inputArr(string mesage)
{
    int[] arr = new int[8];
    int n = 0;
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{mesage} {i} из {arr.Length}:");
        n = int.Parse(Console.ReadLine() ?? "");
        arr[i] = n;
    }
    return arr;
}
static void outputArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write(" -> ");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}
