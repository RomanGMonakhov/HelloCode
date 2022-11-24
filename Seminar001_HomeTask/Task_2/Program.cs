/*
Задача 2:
Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.
*/

Console.Clear();

Console.Write("Enter first number: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
    Console.Write($"max = {n1}, min = {n2}");
else 
    Console.Write($"max = {n2}, min = {n1}");