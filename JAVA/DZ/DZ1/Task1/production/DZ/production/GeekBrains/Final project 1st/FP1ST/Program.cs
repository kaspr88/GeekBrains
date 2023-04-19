int num = inputSizeArray("Введите размер массива: ", "Ошибка ввода");
string[] array1 = FillArray(num);
int sizeArr = sizeArray(array1);
string[] array2 = resultingArray(sizeArr, array1);
if (sizeArr > 0)
{
    Console.WriteLine($"[\"{String.Join("\", \"", array1)}\"] --> [\"{String.Join("\", \"", array2)}\"] ");
}
else
{
    Console.WriteLine($"[\"{String.Join("\", \"", array1)}\"] --> [\"Нет подходящих элементов!\"] ");
}
//**************Ввод размера массива*************
int inputSizeArray(string message, string error)
{
    int num = 0;
    try
    {
        Console.Write(message);
        num = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine(error, ex);
    }
    return num;
}
//**************Создание массима с рандомными строковыми значениями**************
string[] FillArray(int numberOfWords)
{
    string[] randomStrings = new string[numberOfWords];
    Random random = new Random();
    for (int i = 0; i < numberOfWords; i++)
    {
        char[] word = new char[random.Next(6) + 2];
        for (int j = 0; j < word.Length; j++)
        {
            word[j] = (char)('a' + random.Next(26));
        }
        randomStrings[i] = new String(word);
    }
    return randomStrings;
}
//**************Вычисление размера результирующего массива**************
int sizeArray(string[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            n = n + 1;
        }
    }
    return n;
}
//**************Создание массива с результатами выборки************** 
string[] resultingArray(int size, string[] array)
{
    string[] arr = new string[size];
    int b = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[b] = array[i];
            b++;
        }
    }
    return arr;
}
