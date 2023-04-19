// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array = randomFillArray(2, 2, 2, 9, 99);
printArray(array);
int[,,] randomFillArray(int m, int n, int l, int minValue, int maxValue)
{
    int[,,] arr = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                arr[i, j, k] = new Random().Next(minValue, maxValue);
            }

        }
    }
    return arr;
}

void printArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($" {arr[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine(" ");
        }
    }
}