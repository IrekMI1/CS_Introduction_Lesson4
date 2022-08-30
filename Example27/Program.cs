// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetDigitsSum(int number)
{
    int numLength = Convert.ToInt32(Math.Ceiling(Math.Log(number, 10)));
    int digitSum = 0;
    for (int i = 0; i < numLength; i++)
    {
        if(i == 0) digitSum += number / Convert.ToInt32(Math.Pow(10, numLength - 1));
        else digitSum += number / Convert.ToInt32(Math.Pow(10, numLength - 1 - i)) % 10;
    }
    return digitSum;
}

try
{
    Console.Write("Введите целое число: \t");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма цифр числа {num} равна {GetDigitsSum(num)}");
}
catch 
{
    Console.WriteLine("Неверный ввод!");
}