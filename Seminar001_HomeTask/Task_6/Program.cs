/*
Задача 6:
Напишите программу, которая на вход принимает число
и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/

Console.Clear();

Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());

if (n % 2 == 0)
    Console.Write("yes");
else 
    Console.Write("no");