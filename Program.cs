// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
string[] stringsArray = new string[size];
int lessThan3Counter = 0;
Console.WriteLine("Введите строки: ");

for (int i = 0; i < size; i++)
    stringsArray[i] = Console.ReadLine()!;

for (int i = 0; i < size; i++)
{
    if (stringsArray[i].Length < 4)
        lessThan3Counter++;
}

string[] resultString = new string[lessThan3Counter];
lessThan3Counter = 0;

for (int i = 0; i < size; i++)
{
    if (stringsArray[i].Length < 4)
    {
        resultString[lessThan3Counter] = stringsArray[i];
        lessThan3Counter++;
    }
}

Console.WriteLine("\nИтоговый массив: ");

for (int i = 0; i < lessThan3Counter; i++)
{
    Console.WriteLine(resultString[i]);
}