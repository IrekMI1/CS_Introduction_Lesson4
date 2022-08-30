// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void  GetPowerInCycle()
{
    while (true)
    {
        Console.Write("Введите целое основание:  \t");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите целую степень:  \t");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат: ({a})^({b}) = {Math.Pow(a, b)}");
    }
}

try
{
    GetPowerInCycle();
}
catch 
{
    Console.WriteLine("Неверный ввод!");
}