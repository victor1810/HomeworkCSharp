/* Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

int[] A = { new Random().Next(-10, 11), new Random().Next(-10, 11), new Random().Next(-10, 11) };
int[] B = { new Random().Next(-10, 11), new Random().Next(-10, 11), new Random().Next(-10, 11) };

double Distance(int[] a, int[] b)
{
    return Math.Sqrt(Math.Pow((a[0] - b[0]), 2) + Math.Pow((a[1] - b[1]), 2) + Math.Pow((a[2] - b[2]), 2));
}

Console.WriteLine($"Координаты точки A (x = {A[0]}; y = {A[1]}; z = {A[2]})");
Console.WriteLine($"Координаты точки B (x = {B[0]}; y = {B[1]}; z = {B[2]})");
Console.Write($"Расстояние между A и B равно ");
Console.Write(Distance(A, B));