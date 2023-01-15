// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int num = inputArr("Введите элемент массива:");
Console.Write($"{num}");
//Console.Write(getNumber(num));

int inputArr(string mesage)
{
    int namber = 0;
    while (namber <= 8)
    {
        Console.Write(mesage + $" {namber}");
        int[] arr = new int[int.Parse(Console.ReadLine() ?? "")];
        namber++;
    }
    return namber;
}


/*
int getNumber(int num)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        n = arr[i];
    }
    return n;
}*/