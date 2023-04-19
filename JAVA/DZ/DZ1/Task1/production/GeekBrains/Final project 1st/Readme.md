# **Итоговая проверочная работа по блоку №1**

---

[Вспомогательная информация](https://metanit.com/sharp/tutorial/)

[Файл с программой](https://github.com/kaspr88/Block-results/blob/main/FP1ST/Program.cs)

**`Задача:`** Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо рвана 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**`Примеры:`**

```csharp
["hello", "2", "world", ":-)"] --> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] --> ["-2"]
["Russia", "Denmark", "Kazan"] --> []
```

- Схема алгоритма выполнения задачи.

  ![Схема алгоритма выполнения](https://github.com/kaspr88/Block-results/blob/main/FPScheme.png)

## Описание методов для выполнения программы.

---

- **Создаем метод **`inputSizeArray`**, который отвечает за введение колличества элементов в массиве.**

```csharp
int inputSizeArray(string massage, string error)
{
    int num = 0;
    try
    {
        Console.Write(massage);
        num = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine(error, ex);
    }
    return num;
}
```

- **Создаем метод **`FillArray`**, который рандомно заполняет строковые элементы нашего массива.**

```csharp
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
```

- **Создаем метод **`sizeArray`**, для вычисление размера результирующего массива.**

```csharp
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
```

- **Создание массива **`resultingArray`** с результатами выборки.**

```csharp
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
```

- **Ну и собственно вызов методов и исполнение программы**

```csharp
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
```

[Сылка на файл с программой](https://github.com/kaspr88/Block-results/blob/main/FP1ST/Program.cs)
