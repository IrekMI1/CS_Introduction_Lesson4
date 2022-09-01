// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int[] FillArrayFromInput()
{
    return Console.ReadLine().Split(", ").Select(x => Convert.ToInt32(x)).ToArray();
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

try
{
    Console.Write("Введите числа через ', ' (a, b, c): \t");
    int[] array = FillArrayFromInput(); 
    PrintArray(array);
}
catch 
{
    Console.WriteLine("Неверный формат ввода!");
}