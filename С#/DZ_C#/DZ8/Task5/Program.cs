// Напишите программу, которая заполнит спирально массив 4 на 4

int[,] array = fillArray();
printArray(array);


int[,] fillArray()
{
    int[,] arr = new int[4, 4];
    int a = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                //a = a + arr[i, k];
                arr[i, k] = a + i;
            }

        }
    }
    return arr;
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}