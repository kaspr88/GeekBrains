// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int number = getNumber("Введите число: ", "Ошибка ввода!");
int sum = getSum(number);
Console.Write($"{number} -> {sum}");

int getNumber(string messege, string error)
{
    while (true)
    {
        Console.Write(messege);
        bool Num = int.TryParse(Console.ReadLine(), out int userNum);
        if (Num) return userNum;
        Console.WriteLine(error);
    }
}
int getSum(int number)
{
    int result = 0;
    while (true)
    {
        int a = number % 10;
        number = number / 10;
        result += a;
        if (number <= 0) break;
    }
    return result;
}