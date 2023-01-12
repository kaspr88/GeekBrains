GetArr();

static void GetArr()
{
    int numbers = new Random().Next(0, 2);
    for (int i = 0; i < 8; i++)
    {
        numbers = new Random().Next(0, 2);
        Console.WriteLine($"{numbers}");
        if (i < 7) Console.Write(",");

    }


}
