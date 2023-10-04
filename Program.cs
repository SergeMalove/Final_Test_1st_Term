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
    string[] array = new string[size];
    Console.WriteLine($"Введите {size} строк массива: ");

    for (int i = 0; i < size; i++)
        array[i] = Console.ReadLine()!;

    return array;
}

string[] GetLessThanThreeSymbolStrings(string[] array)
{
    int counter = 0;
    foreach (string s in array)
    {
        if (s.Length < 4)
            counter++;
    }

    if (counter == 0)
    {
        return new string[1] { "\nВо введенном массиве нет срок имеющих длину меньшую либо равную 3-м символам.\n" };
    }
    else
    {
        string[] result = new string[counter + 1];
        result[0] = "\nВ исходном массиве следующие строки имеют длину меньшую либо равную 3-м символам:";
        counter = 1;

        foreach (string s in array)
        {
            if (s.Length < 4)
            {
                result[counter] = s;
                counter++;
            }
        }

        return result;
    }
}

string[] stringsArray = CreateArray(InputArraySize());
string[] resultString = GetLessThanThreeSymbolStrings(stringsArray);
Console.WriteLine(String.Join("\n", resultString));    // Строка не участвующая в проверке задания. Нужна только для проверки работы программы.