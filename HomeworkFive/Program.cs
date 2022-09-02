/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2                           */

int[] array = { new Random().Next(1000), new Random().Next(1000), new Random().Next(1000), new Random().Next(1000) };
int j = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
        j += 1;


Console.Write($"[{array[0]}, {array[1]}, {array[2]}, {array[3]}] -> {j}");