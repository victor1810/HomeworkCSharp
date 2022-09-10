/* Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9               */

Console.WriteLine();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int funAckermann = Ack(m, n);

Console.WriteLine($"A(m,n) = {funAckermann}\n");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}