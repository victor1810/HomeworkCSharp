/* Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел. */

int a = new Random().Next(1, 100);
int b = new Random().Next(1, 100);
int c = new Random().Next(1, 100);

int max = a;

if (b > max)
    max = b;
if (c > max)
    max = c;
Console.Write($"a = {a}, b = {b}, c = {c}. max ->  {max}");