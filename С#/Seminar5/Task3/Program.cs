Console.Clear();
//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
int[] array = RandomArray(5, 0, 5);
int num = inputNumber("Введиете искомую переменную: ");
string value = searchValue(array, num);
Console.WriteLine($"{num} Массив [{String.Join(" ", array)}] --> {value}");
///////////////////////////
string searchValue(int[] arr, int number)
{
    string result = "нет";
    int i = 0;
    while (i < arr.Length)
    {
        result = arr[i] == number ? "да" : "нет";
        i++;
    }
    return result;
}
///////////////////////////////
int inputNumber(string message)
{
    int number = 0;
    try
    {
        Console.Write(message);
        number = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Не верный формат!{ex}");
    }
    return number;
}
/////////////////////////
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}
