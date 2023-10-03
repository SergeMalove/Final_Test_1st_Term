// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

int InputArraySize()
{
    int number = 0;
    while (true)
    {
        Console.Write("Введите размер массива: ");
        try
        {
            number = int.Parse(Console.ReadLine()!);
            if (number > 0)
                break;
            Console.WriteLine("\nРазмер массива не может быть отрицательным числом. Пожалуйста повторите ввод.\n");
        }
        catch (Exception)
        {
            Console.WriteLine("\nНеверный ввод. Пожалуйста повторите ввод.\n");
        }
    }

    return number;
}

string[] CreateArray(int size)
{
    string[] array = new string[size + 1];
    int counter = 0;
    Console.WriteLine($"Введите {size} строк массива: ");

    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine()!;
        if (array[i].Length < 4)
            counter++;
    }
    array[size] = counter.ToString();

    return array;
}

string[] GetLessThanThreeSymbolStrings(string[] array)
{
    int counter = int.Parse(array[array.Length - 1]);
    string[] result = new string[counter];
    counter = 0;

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i].Length < 4)
        {
            result[counter] = array[i];
            counter++;
        }
    }

    return result;
}

string[] stringsArray = CreateArray(InputArraySize());
string[] resultString = GetLessThanThreeSymbolStrings(stringsArray);
Console.WriteLine("\nВ исходном массиве следующие строки имеют длину меньше либо равны 3-м символам:");
Console.WriteLine(String.Join("\n", resultString));