/*Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */
Console.Clear();
int[] arr = RandomArray(4, -9, 9);
int[] val = invertValue(arr);
Console.WriteLine($"{String.Join(" ", arr)}");
Console.WriteLine($"{String.Join(" ", val)}");
////////////////
int[] invertValue(int[] array)
{
    int[] arra = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        arra[i] = array[i];
    }
    for (int i = 0; i < arra.Length; i++)
    {
        arra[i] *= -1;
    }
    return arra;
}
//////////////
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] arra = new int[size];
    for (int i = 0; i < arra.Length; i++)
    {
        arra[i] = new Random().Next(-9, 9);
    }
    return arra;
}