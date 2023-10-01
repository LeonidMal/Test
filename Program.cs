Console.WriteLine("Введите количество элементов в массиве");

int size = Convert.ToInt32(Console.ReadLine());

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

string[] FixedArray(string[] arr2, int charCount, int newArraySize)
{
    string[] tempArray = new string[newArraySize];
    int n = 0;
    for (int l = 0; l < newArraySize; l++)
    {
        if (arr2[l].Length <= charCount)
        {
            tempArray[n] = arr2[l];
            n++;
        }
    }
    return tempArray;
}

string[] newArray = FixedArray(array, maxChar, maxSize);
Console.Clear();

Console.Write("[");
for (int p = 0; p < size - 1; p++)
{
    Console.Write($"'{array[p]}', ");
}
Console.Write($"'{array[size - 1]}' ] -> [");
for (int i = 0; i < maxSize - 1; i++)
{
    Console.Write($"'{newArray[i]}', ");
}
Console.Write($"'{newArray[maxSize - 1]}' ]");