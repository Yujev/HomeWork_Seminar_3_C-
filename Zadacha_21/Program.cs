/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите координыты точки X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координыты точки Y: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координыты точки Z: ");
int z = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координыты точки X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координыты точки Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координыты точки Z1: ");
int z1 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2) + Math.Pow(z1 - z, 2));
Console.WriteLine($"Расстояние между точками равно -> {result:f2}");