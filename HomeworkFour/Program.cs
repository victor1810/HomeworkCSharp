/* Задача 29: Напишите программу, которая задаёт
массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]                */

int[] CreatedArray(int size, int min = 0, int max = 100)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

foreach (var el in CreatedArray(8))
    Console.Write($"{el} ");
