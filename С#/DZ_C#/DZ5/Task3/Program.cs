// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
int[] array = RandomArray(10, 0, 100);
int defValue = sumValue(array);
Console.WriteLine($"[{String.Join(" ", array)}] --> {defValue} ");
//<-----Разниц между максимальным и минимальным элементов массива----->//
int sumValue(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (max < arr[i])
        {
            max = array[i];
        }
        if (min > arr[i])
        {
            min = array[i];
        }
    }
    int def = max - min;
    return def;
}
//<--------------Массив заполненный случайными числами---------------->//
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}