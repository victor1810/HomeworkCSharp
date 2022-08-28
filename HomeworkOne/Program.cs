/* Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N */

int num = new Random().Next(1, 100);
int index = 1;

Console.Write($"N = {num}:  ");

while ((index - 1) < num)
{
    if (index % 2 == 0)
        Console.Write($"{index}, ");
    index++;
}