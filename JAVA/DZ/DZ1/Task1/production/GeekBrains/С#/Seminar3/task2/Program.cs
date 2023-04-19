Console.WriteLine("Ведите координаты точки A");
int ax = int.Parse(Console.ReadLine() ?? "");
int ay = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Ведите координаты точки B");
int bx = int.Parse(Console.ReadLine() ?? "");
int by = int.Parse(Console.ReadLine() ?? "");



double result = Math.Round(Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2)), 2);

Console.WriteLine(result);
