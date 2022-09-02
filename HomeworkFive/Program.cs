/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76                                             */

int[] array = { new Random().Next(-99, 100), new Random().Next(-99, 100), new Random().Next(-99, 100), new Random().Next(-99, 100), new Random().Next(-99, 100) };
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);

int max = array[0];
int min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (max < array[i])
        max = array[i];

    if (min > array[i])
        min = array[i];
}
int diff = max - min;
Console.Write($"[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}] ");
Console.WriteLine($"-> max({max}) - min({min}) = {diff}");