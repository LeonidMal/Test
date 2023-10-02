Console.Write("Введите количество элементов в массиве: ");


string stringSize = Console.ReadLine();
int index = 0;
int digitCount = 0;
int size = 0;
bool isInt = false;


while (index < stringSize.Length)
{
    switch (stringSize[index])
    {
        case '0':
            index++;
            digitCount = index;
            break;
        case '1':
            index++;
            digitCount = index;
            break;
        case '2':
            index++;
            digitCount = index;
            break;
        case '3':
            index++;
            digitCount = index;
            break;
        case '4':
            index++;
            digitCount = index;
            break;
        case '5':
            index++;
            digitCount = index;
            break;
        case '6':
            index++;
            digitCount = index;
            break;
        case '7':
            index++;
            digitCount = index;
            break;
        case '8':
            index++;
            digitCount = index;
            break;
        case '9':
            index++;
            digitCount = index;
            break;
        default:
            digitCount = index;
            index++;
            break;
    }
}


if (digitCount != stringSize.Length)
    Console.WriteLine($"{stringSize} - Пожалуйста, введите число!");
else
{
    size = Convert.ToInt32(stringSize);
    if (size > 0)
        isInt = true;
    else
        Console.WriteLine($"{stringSize} - Только положительные числа!");
}


if (isInt == true)
{
    string[] array = new string[size];
    int maxChar = 3;
    int maxSize = 0;


    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите значение элемента массива");
        array[i] = Console.ReadLine();
    }


    for (int m = 0; m < size; m++)
    {
        if (array[m].Length <= maxChar)
            maxSize++;
    }


    string[] newArray = FixedArray(array, maxChar, maxSize);
    Console.Clear();


    Console.Write("[");
    for (int p = 0; p < size - 1; p++)
    {
        Console.Write($"'{array[p]}', ");
    }
    Console.Write($"'{array[size - 1]}' ] -> [");
    for (int q = 0; q < maxSize - 1; q++)
    {
        Console.Write($"'{newArray[q]}', ");
    }
    Console.Write($"'{newArray[maxSize - 1]}' ]");
}


    string[] FixedArray(string[] arr2, int charCount, int newArraySize)
    {
        string[] tempArray = new string[newArraySize];
        int n = 0;
        for (int l = 0; l < size; l++)
        {
            if (arr2[l].Length <= charCount)
            {
                tempArray[n] = arr2[l];
                n++;
            }
        }
        return tempArray;
    }