//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Write("Введите число: ");
int n = inputNumber();
int longArr = longArray(n);
int[] arr = ConvertDoubleSystem(n, longArr);
Console.WriteLine($"{n} -- > {String.Join("", arr)}");
int[] ConvertDoubleSystem(int num, int longArray)
{
    int[] array = new int[longArray];
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        a = num % 2;
        num = num / 2;
        array[i] = a;
    }
    return array;
}
int inputNumber()
{
    int num = int.Parse(Console.ReadLine() ?? "");
    return num;
}
int longArray(int num)
{
    int a = 0;
    int b = 0;
    for (int i = 0; ; i++)
    {
        a = num % 2;
        num = num / 2;
        b = i;
        if (num == 0) break;

    }
    return b + 1;
}