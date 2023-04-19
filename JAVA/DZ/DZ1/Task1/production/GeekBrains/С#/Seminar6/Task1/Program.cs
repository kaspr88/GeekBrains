//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int[] array = new int[3];
inputNumber(array);
if (array[0] < array[1] + array[2] && array[1] < array[2] + array[0] && array[2] < array[0] + array[1])
{
    Console.Write($"Треугольник может существовать");
}
else
{
    Console.Write($"Треугольник не может существовать");
}
static void inputNumber(int[] arr)
{
    try
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Введите сторону треугольника ");
            int num = int.Parse(Console.ReadLine() ?? "");
            arr[i] = num;
        }

    }
    catch (Exception ex)
    {
        Console.Write($"Ошибка ввода данных:{ex.Message}");
        return;
    }
}