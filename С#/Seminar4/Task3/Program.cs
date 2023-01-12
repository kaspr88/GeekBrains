GetArr();

int GetArr()
{
    int numbers = new Random().Next(0, 2);
    for (int i = 0; i < 8; i++)
    {
        int numbers = new Random().Next(0, 2);
        Console.WriteLine($"{numbers}");
        if (inde < 7) Console.Write(",");

    }


}
