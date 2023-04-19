/*string[] array = new string[20];
string[] array2 = new string[10];
int a = 4;
int b = 5;
int c = 4;
int d = 5;
int e = 0;
int f = 0;
int g = 1;
int h = 1;
for (int k = 0; ; k++)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array2.Length; j++)
        {
            array[j] = " . ";
            if ((j == a) && (i == e)) array[j] = " + ";
            if ((j == b) && (i == f)) array[j] = " + ";
            if ((j == c) && (i == g)) array[j] = " + ";
            if ((j == d) && (i == h)) array[j] = " + ";
            Console.Write(array[j]);
        }
        Console.WriteLine("");
    }
    string input = Console.ReadLine() ?? "";
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

}*/

// создаем новый поток
Thread myThread1 = new Thread(Print);
Thread myThread2 = new Thread(new ThreadStart(Print));
Thread myThread3 = new Thread(() => Console.WriteLine("Hello Threads"));

myThread1.Start();  // запускаем поток myThread1
myThread2.Start();  // запускаем поток myThread2
myThread3.Start();  // запускаем поток myThread3

void Print() => Console.WriteLine("Hello Threads");