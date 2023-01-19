//Напишите программу, которая будет преобразовывать десятичное число в двоичное.


static void inputNumber(int num)
{
    try
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Введите пятизначное число: ");
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