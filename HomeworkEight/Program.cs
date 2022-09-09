/* Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.   */

int m = InputNumbers(""); // Число строк 1-й матрицы
int n = InputNumbers(""); // Число столбцов 1-й матрицы и строк 2-й
int p = InputNumbers(""); // Число столбцов 2-й матрицы

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secomdMartrix);

int[,] sumMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, sumMatrix);
Console.WriteLine($"\nПроизведение матриц:");
PrintArray(sumMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] sumMatrix)
{
    for (int i = 0; i < sumMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sumMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            sumMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = new Random().Next(3, 7);
    return output;
}

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}