// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = inputArr("Введите элемент", "Введены не коррктные данные!");
outputArr(array);
int[] inputArr(string mesage, string error)
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{mesage} {i} из {arr.Length}:");
        bool isCorrect = int.TryParse(Console.ReadLine(), out int n);
        arr[i] = n;
        if (!isCorrect)
        {
            Console.WriteLine(error);
            break;
        };

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
    Console.Write(" -> [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}
