/* Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее. */

int a = new Random().Next(1, 1000);
int b = new Random().Next(1, 1000);

if (a > b)
    Console.Write($"a = {a}; b = {b} -> max = {a}");
else
    Console.Write($"a = {a}; b = {b} -> max = {b}");