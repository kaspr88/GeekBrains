//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
int[] arr = new int[4];
int j = 0;
int number = 0;
string result = "нет";
/////////////////////
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 5);
}
/////////////////////
Console.Write($"Введите искомое число: ");
number = int.Parse(Console.ReadLine() ?? "");
///////////////////////
while (j < arr.Length)
{
    result = arr[j] == number ? "да" : "нет";
    j++;
}
Console.WriteLine($"{number} Массив [{String.Join(" ", arr)}] --> {result}");