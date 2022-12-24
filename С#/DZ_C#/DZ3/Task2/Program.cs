/*Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.*/
Console.Clear();
int ax = 0, ay = 0, az = 0, bx = 0, by = 0, bz = 0;
inputDotCoor(ref ax, ref ay, ref az, ref bx, ref by, ref bz);

static void inputDotCoor(ref int ax, ref int ay, ref int az, ref int bx, ref int by, ref int bz)
{
    try
    {
        Console.WriteLine("Введите ax");
        ax = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Введите ay");
        ay = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Введите az");
        az = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Введите bx");
        bx = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Введите by");
        by = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Введите bz");
        bz = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Не верный формат данных {ex.Message}");
        return;

    }

    static void lengthSegment(int ax, int ay, int az, int bx, int by, int bz)
    {
        double result = Math.Round(Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2)), 2);
        Console.WriteLine(result);

    }
    lengthSegment(ax, ay, az, bx, by, bz);
}



