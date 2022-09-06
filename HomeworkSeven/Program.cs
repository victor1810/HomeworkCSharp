/* Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами. m = 3, n = 4  ->
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9     */
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);

void FillArray(double[,] _array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            _array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] _array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
}