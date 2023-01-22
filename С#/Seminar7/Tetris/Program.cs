Console.Clear();
string[] array = new string[20];
string[] array2 = new string[10];
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)
    {

        array[j] = " . ";
        if ((j == 4) && (i == 0)) array[j] = " + ";
        if ((j == 5) && (i == 0)) array[j] = " + ";
        if ((j == 4) && (i == 1)) array[j] = " + ";
        if ((j == 5) && (i == 1)) array[j] = " + ";
        Console.Write(array[j]);

    }
    Console.WriteLine("");
}