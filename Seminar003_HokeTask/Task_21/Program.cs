/*
Задача 21:
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.WriteLine("Enter point's A coordinates (x, y, z): ");
double ax = double.Parse(Console.ReadLine());
double ay = double.Parse(Console.ReadLine());
double az = double.Parse(Console.ReadLine());

Console.WriteLine("Enter point's B coordinates (x, y, z): ");
double bx = double.Parse(Console.ReadLine());
double by = double.Parse(Console.ReadLine());
double bz = double.Parse(Console.ReadLine());

double rezult = Math.Round(Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2)), 2);

Console.WriteLine($"Result: {rezult}");