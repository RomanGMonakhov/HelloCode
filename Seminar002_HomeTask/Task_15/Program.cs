/*
Задача 15:
Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/

Console.Clear();

Console.Write("Enter the week day number: ");
int n = int.Parse(Console.ReadLine());

if (n == 6 | n == 7)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");