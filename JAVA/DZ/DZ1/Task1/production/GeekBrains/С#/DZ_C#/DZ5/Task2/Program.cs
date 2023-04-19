// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] array = RandomArray(10, 0, 10);
int sumNotEvent = sumNotEvents(array);
Console.WriteLine($"[{String.Join(" ", array)}] --> {sumNotEvent}");
//<--------------Cумму элементов стоящих на нечётных позициях---------------->//
int sumNotEvents(int[] arr)
{
    int n = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        n = arr[i] + n;
    }
    return n;
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
