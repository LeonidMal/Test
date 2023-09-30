Console.WriteLine("Введите количество элементов в массиве");

int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
int maxChar = 3;
int maxSize = 0;

 
string[] FillArray (string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите значение элемента массива");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

FillArray(array);