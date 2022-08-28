/* Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет. */

int number = new Random().Next(10, 100000);
int s = number.ToString().Length;

int DigitOfNumber(int num, int n)
{
    return num / (int)Math.Pow(10, s - n) % 10;
}
if (s <= 2)
    Console.Write($"{number} -> третьей цифры нет");
else
    Console.Write($"{number} -> {DigitOfNumber(number, 3)}");