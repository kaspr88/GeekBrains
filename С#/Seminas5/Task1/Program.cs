//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] arr = RandomArray(12, -9, 9);
Console.WriteLine(($"{negativeSum(arr)}, {positiveSum(arr)}", String.Join(" ", arr)));
/////////////////////////////////////
int negativeSum(int[] array)
{
    int sm1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sm1 = array[i] + sm1;
        }
    }
    return sm1;
}
/////////////////////////////////////
int positiveSum(int[] array)
{
    int sm2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sm2 = array[i] + sm2;
        }
    }
    return sm2;
}
/////////////////////////////////////
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
    }
    return arr;
}