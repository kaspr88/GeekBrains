Console.Clear();
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
int[] array = new int[20] { 5, 2, 3, 4, 5, 6, 7, 8, 9, 5, 2, 3, 4, 5, 6, 7, 8, 9, 7, 3 };
int[] array2 = new int[array.Length / 2];


for (int i = 0; i < array2.Length; i++)
{
    int a = array[i];
    int b = array[array.Length - i - 1];
    array2[i] = a * b;
    Console.WriteLine($"{a} --> {b} --> {String.Join(" ", array2)}");
}
//Console.WriteLine($"{String.Join(" ", array)} --> {String.Join(" ", array2)}");
