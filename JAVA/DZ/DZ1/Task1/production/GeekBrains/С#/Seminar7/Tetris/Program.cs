string[] array = new string[20];
string[] array2 = new string[10];
int a = 4;
int b = 5;
int c = 4;
int d = 5;
int e = 0;
int f = 0;
int g = 1;
int h = 1;
while (true)
{
    positionDefault(ref array, ref array2, ref a, ref b, ref c, ref d);
    int time = 1001;
    Thread.Sleep(time);
    moveToBottom(ref e, ref f, ref g, ref h);
    string directionInfo = enterDirection();
    moveToLeftToRight(ref directionInfo, ref a, ref b, ref c, ref d);
    Console.Clear();
}
//////////////////////////////////////
// создаем новый поток
//Thread myThread = new Thread(enterDirection);
// запускаем поток myThread
//myThread.Start();
string enterDirection()
{
    string direction = "0";
    try
    {
        Console.WriteLine("Введите направление");
        direction = Console.ReadLine() ?? "";

    }
    catch (Exception ex)
    {
        Console.WriteLine("Введите нужное направлени", ex);
    }
    return direction;
}
////////////////////////////////
void positionDefault(ref string[] array, ref string[] array2, ref int a, ref int b, ref int c, ref int d)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array2.Length; j++)
        {
            array[j] = "   ";
            if ((j == a) && (i == e)) array[j] = " + ";
            if ((j == b) && (i == f)) array[j] = " + ";
            if ((j == c) && (i == g)) array[j] = " + ";
            if ((j == d) && (i == h)) array[j] = " + ";
            Console.Write(array[j]);
        }
        Console.WriteLine("");
    }


}
/////////////////////////////////
void moveToLeftToRight(ref string input, ref int a, ref int b, ref int c, ref int d)
{
    if (input == "d")
    {
        a = a + 1;
        b = b + 1;
        c = c + 1;
        d = d + 1;
    }
    if (input == "a")
    {
        a = a - 1;
        b = b - 1;
        c = c - 1;
        d = d - 1;
    }
}
/////////////////////////////////
void moveToBottom(ref int e, ref int f, ref int g, ref int h)
{

    e = e + 1;
    f = f + 1;
    g = g + 1;
    h = h + 1;

}
