/*
Задача 4:
Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
*/

Console.Clear();

Console.Write("Enter first number: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("Enter third number: ");
int n3 = int.Parse(Console.ReadLine());

if ((n1 >= n2) && (n1 >= n3))
    Console.Write($"max = {n1}");
else if
    (n2 >= n3) Console.Write($"max = {n2}");
else
    Console.Write($"max = {n3}");