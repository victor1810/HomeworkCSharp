/* Задача 27: Напишите программу, которая принимает
на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12                                       */

int num = new Random().Next(10000);

int SumNum(int num)
{
    int count = Convert.ToString(num).Length;
    int step = 0;
    int sum = 0;

    for (int i = 0; i < count; i++)
    {
        step = num % 10;
        sum = sum + step;
        num = num / 10;
    }
    return sum;
}
Console.WriteLine($"{num} -> {SumNum(num)}");