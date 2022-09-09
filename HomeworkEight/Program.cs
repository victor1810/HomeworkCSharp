/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.          */

int m = InputNumbers("");
int n = InputNumbers("");

int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);

int minSumLine = 0;
int minSum = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempMinSum = SumLineElements(array, i);
    if (minSum > tempMinSum)
    {
        minSum = tempMinSum;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({minSum})");

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = new Random().Next(3, 10);
    return output;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}