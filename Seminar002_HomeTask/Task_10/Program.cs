/*
Задача 10:
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
*/

Console.Clear();

Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"The second digit is : {n / 10 % 10}");