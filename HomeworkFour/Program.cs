﻿/* Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16                                                 */

int A = new Random().Next(10);
int B = new Random().Next(5);

int power = 1;
for (int i = 1; i <= B; i++)
{
    power *= A;
}

Console.WriteLine($"A = {A}; B = {B} -> {power}");