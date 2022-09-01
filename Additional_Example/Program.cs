// необязательная задача
// Написать программу, которая сортирует массив от большего к меньшему и находит медианное значение. 
// Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры.

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

int[] FillPrintArray()
{
    Console.Write("Введите длину массива: \t");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    Console.Write("Исходный массив: \t[");
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
    return array;
}

int[] SortArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[i]) 
            {
                temp = array[i];
                array[i] = array[j]; 
                array[j] = temp;
            }
        }
    }
    return array;
}

double GetSortedArrayMedian(int[] array)
{
    int size = array.Length;
    if (size % 2 == 1) return array[size / 2];
    else 
    {
        return (array[size / 2 - 1] + array[size / 2]) / 2.0;
    }
}

try
{
    int[] randomArray = FillPrintArray();
    Console.Write("Сортированный массив:\t");
    int[] sortedArray = SortArray(randomArray);
    PrintArray(sortedArray);
    Console.WriteLine();
    Console.Write($"Медианное значение: \t{GetSortedArrayMedian(sortedArray)}");
}
catch 
{
    Console.WriteLine("Fatal Error!");
}