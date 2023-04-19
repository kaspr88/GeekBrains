
/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.*/
static void inputNumber(ref int num)
{
    try
    {
        Console.Write("Введите пятизначное число: ");
        num = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.Write($"Ошибка ввода данных:{ex.Message}");
        return;
    }
}

static void printNumber(int num)
{
    int left1 = num / 10000;
    int left2 = (num / 1000) % 10;
    int right1 = num % 10;
    int right2 = (num % 100) / 10;

    if (left1 == right1 || left2 == right2) Console.Write($"{num} -> да");
    else Console.Write($"{num} -> нет");
}

int x = 0;
inputNumber(ref x);
printNumber(x);