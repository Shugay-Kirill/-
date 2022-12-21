

string[] InputArray()
{
    int index = 1;
    string[] arrayData = new string[index];

    Console.Write(@$"Введите {index} значение массива (Для завершения ввода данных нажмите на'ENTER') = ");
    string data = Console.ReadLine();

    while (data != "")
    {
        Array.Resize(ref arrayData, index);
        arrayData[index - 1] = data;
        index++;

        Console.Write($"Введите {index} значение массива(Для завершения ввода данных нажмите на'ENTER') = ");
        data = Console.ReadLine();

    }
    return arrayData;
}

void PrintArray(string[] arrayData)
{
    Console.Write("[");
    for (int i = 0; i < arrayData.Length; i++)
    {
        Console.Write(arrayData[i]);
        if (i != arrayData.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
}

string[] CheckArray(string[] arrayData)
{
    int count = 0;
    string[] resultArray = new string[count];

    for (int i = 0; i < arrayData.Length; i++)
    {
        if (arrayData[i].Length <= 3)
        {
            count++;
            Array.Resize(ref resultArray, count);
            resultArray[count - 1] = arrayData[i];
        }
    }
    return resultArray;
}

void Main()
{
    string[] arrayData = InputArray();
    Console.WriteLine("Исходный массив данных:");
    PrintArray(arrayData);
    Console.WriteLine();
    string[] resultArray = CheckArray(arrayData);
    Console.WriteLine("Новый массив данных:");
    PrintArray(resultArray);
}

Main();