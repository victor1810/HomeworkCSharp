﻿/* Задача 66: Задайте значения M и N. Напишите программу, которая
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30                    */

int m = new Random().Next(-9, 10);
int n = new Random().Next(-9, 10);
int temp = m;

Console.WriteLine($"M = {m}");
Console.WriteLine($"N = {n}\n");

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ}");
        return;
    }
    PrintSumm(m, n - 1, summ);
}
