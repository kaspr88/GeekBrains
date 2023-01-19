//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
int[] array = RandomArray(123, 0, 123);
int namber = rangeNamber(array);

Console.WriteLine($"[{String.Join(",", array)}] --> {namber}");
int rangeNamber(int[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] < 10) || (arr[i] > 99))
        {
            n++;
        }
    }
    return n;
}
//////////////
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

