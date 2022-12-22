Console.WriteLine("Ведите координаты точки A");
int x = int.Parse(Console.ReadLine() ?? "");
int y = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Ведите координаты точки B");
int x1 = int.Parse(Console.ReadLine() ?? "");
int y1 = int.Parse(Console.ReadLine() ?? "");



int a = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2));

Console.WriteLine(a);
