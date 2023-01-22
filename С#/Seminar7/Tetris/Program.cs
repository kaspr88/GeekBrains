Console.Clear();
string[] array = new string[20];
string[] array2 = new string[10];
positionDefault(ref array, ref array2);
string directionInfo = enterDirection();
while (true)
{

    if (directionInfo == "d")
    {
        moveToLeft(directionInfo, ref array, ref array2);
    }
    enterDirection();
}


//////////////////////////////////////
string enterDirection()
{
    string direction = "0";
    try
    {
        Console.WriteLine("Введите направление");
        direction = Console.ReadLine();

    }
    catch (Exception ex)
    {
        Console.WriteLine("Введите нужное направлени", ex);
    }
    return direction;
}
////////////////////////////////
void positionDefault(ref string[] array, ref string[] array2)
{
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


}
/////////////////////////////////
void moveToLeft(string value, ref string[] array, ref string[] array2)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array2.Length; j++)
        {
            array[j] = " . ";
            if ((j == j + 1) && (i == 0)) array[j] = " + ";
            if ((j == j + 1) && (i == 0)) array[j] = " + ";
            if ((j == j + 1) && (i == 1)) array[j] = " + ";
            if ((j == j + 1) && (i == 1)) array[j] = " + ";
            Console.Write(array[j]);
        }
        Console.WriteLine("");
    }
}