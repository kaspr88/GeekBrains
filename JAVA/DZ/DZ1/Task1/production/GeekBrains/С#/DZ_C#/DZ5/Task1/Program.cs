//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
int[] array = RandomArray(10, 99, 1000);
int sumEvenNumber = sumEvenNumbers(array);
Console.WriteLine($"[{String.Join(" ", array)}] --> {sumEvenNumber}");
//<--------------------Подсчет количества четных чисел в массиве------------------->//
int sumEvenNumbers(int[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) n++;
    }
    return n;
}
//<--------------Массив заполненный случайными трехзначными числами---------------->//
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}