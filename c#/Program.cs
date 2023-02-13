
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array1 = { "gryo", "2", "pice", ":-)" };
string[] array2 = { "123456", "20001", "+34", "java" };
string[] array3 = { "Belarus", "Barcelona", "Astana" };

int MAX_LENGTH = 3;


string[] GetShortWordsArray(string[] array) 
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= MAX_LENGTH)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}


void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Массив пуст");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}


void PrintTask(string[] array)
{
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    string[] shortArray = GetShortWordsArray(array);
    Console.WriteLine($"Массив результатов (слов меньше или равно, чем {MAX_LENGTH})");
    PrintArray(shortArray);
    Console.WriteLine();
}

PrintTask(array1);
PrintTask(array2);
PrintTask(array3);

